namespace mcdavid_is_the_oilers

open System
open System.Collections
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.DependencyInjection
open FSharp.Data
open Types

type Startup() =

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    member this.ConfigureServices(services: IServiceCollection) =
        ()

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    member this.Configure(app: IApplicationBuilder, env: IHostingEnvironment) =
        if env.IsDevelopment() then
            app.UseDeveloperExceptionPage() |> ignore

        app.Run(fun context ->
            let totalTeamGoals =
                "https://statsapi.web.nhl.com/api/v1/standings"
                |> Standings.Load
                |> fun s -> s.Records
                |> Seq.collect(fun r -> r.TeamRecords)
                |> Seq.find(fun t -> t.Team.Id = 22)
                |> fun t -> decimal t.GoalsScored

            let playerPoints =
                "https://statsapi.web.nhl.com/api/v1/people/8478402/stats?stats=statsSingleSeason"
                |> PlayerStats.Load
                |> fun r -> r.Stats
                |> Seq.find(fun r -> r.Splits.Length > 0)
                |> fun s -> s.Splits
                |> Seq.find(fun s -> s.Season = 20182019)
                |> fun s -> decimal (s.Stat.Goals + s.Stat.Assists)

            context.Response.WriteAsync(@"
            <html>
                <head>
                    <title>McDavid is the Oilers</title>
                    <link href=""https://fonts.googleapis.com/css?family=Sintony"" rel=""stylesheet"">
                    <style>
                        body {
                            background-color: #ff5112;
                            font-family: 'Sintony', sans-serif;
                        }
                        div {
                            text-align: center;
                        }
                        .wrapper {
                            height: 100%;
                            display: flex;
                            justify-content: center;
                            flex-direction: column;
                        }
                        .message {
                            color: #091f40;
                            font-size: 5rem;
                        }
                        .percent {
                            color: #ffffff;
                            font-size: 8rem;
                        }
                        .disclaimer {
                            position: fixed;
                            bottom: 10px;
                            right: 10px;
                        }
                    </style>
                </head>
                <body>
                    <div class=""wrapper"">
                        <div class=""message"">McDavid has points on</div>
                        <div class=""percent"">" + sprintf "%.2f%%" (playerPoints * 100M / totalTeamGoals) + @"</div>
                        <div class=""message"">of Edmonton's goals</div>
                    </div>
                    <div class=""disclaimer"">* in 2018/19</div>
                </body>
            </html>")
        ) |> ignore