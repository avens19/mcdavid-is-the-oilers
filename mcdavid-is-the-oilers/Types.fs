module Types

open FSharp.Data

type Standings = JsonProvider<"""
{
  "copyright" : "NHL and the NHL Shield are registered trademarks of the National Hockey League. NHL and NHL team marks are the property of the NHL and its teams. © NHL 2018. All Rights Reserved.",
  "records" : [ {
    "standingsType" : "regularSeason",
    "league" : {
      "id" : 133,
      "name" : "National Hockey League",
      "link" : "/api/v1/league/133"
    },
    "division" : {
      "id" : 18,
      "name" : "Metropolitan",
      "nameShort" : "Metro",
      "link" : "/api/v1/divisions/18",
      "abbreviation" : "M"
    },
    "conference" : {
      "id" : 6,
      "name" : "Eastern",
      "link" : "/api/v1/conferences/6"
    },
    "teamRecords" : [ {
      "team" : {
        "id" : 12,
        "name" : "Carolina Hurricanes",
        "link" : "/api/v1/teams/12"
      },
      "leagueRecord" : {
        "wins" : 2,
        "losses" : 0,
        "ot" : 1,
        "type" : "league"
      },
      "goalsAgainst" : 8,
      "goalsScored" : 12,
      "points" : 5,
      "divisionRank" : "1",
      "conferenceRank" : "1",
      "leagueRank" : "1",
      "wildCardRank" : "0",
      "row" : 2,
      "gamesPlayed" : 3,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 2,
        "streakCode" : "W2"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 15,
        "name" : "Washington Capitals",
        "link" : "/api/v1/teams/15"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 0,
        "ot" : 1,
        "type" : "league"
      },
      "goalsAgainst" : 7,
      "goalsScored" : 13,
      "points" : 3,
      "divisionRank" : "2",
      "conferenceRank" : "3",
      "leagueRank" : "8",
      "wildCardRank" : "0",
      "row" : 1,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "ot",
        "streakNumber" : 1,
        "streakCode" : "OT1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 1,
        "name" : "New Jersey Devils",
        "link" : "/api/v1/teams/1"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 0,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 2,
      "goalsScored" : 5,
      "points" : 2,
      "divisionRank" : "3",
      "conferenceRank" : "6",
      "leagueRank" : "12",
      "wildCardRank" : "0",
      "row" : 1,
      "gamesPlayed" : 1,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 1,
        "streakCode" : "W1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 2,
        "name" : "New York Islanders",
        "link" : "/api/v1/teams/2"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 1,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 5,
      "goalsScored" : 5,
      "points" : 2,
      "divisionRank" : "4",
      "conferenceRank" : "8",
      "leagueRank" : "15",
      "wildCardRank" : "2",
      "row" : 1,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "losses",
        "streakNumber" : 1,
        "streakCode" : "L1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 4,
        "name" : "Philadelphia Flyers",
        "link" : "/api/v1/teams/4"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 1,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 7,
      "goalsScored" : 7,
      "points" : 2,
      "divisionRank" : "5",
      "conferenceRank" : "9",
      "leagueRank" : "16",
      "wildCardRank" : "3",
      "row" : 1,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "losses",
        "streakNumber" : 1,
        "streakCode" : "L1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 29,
        "name" : "Columbus Blue Jackets",
        "link" : "/api/v1/teams/29"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 1,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 5,
      "goalsScored" : 4,
      "points" : 2,
      "divisionRank" : "6",
      "conferenceRank" : "10",
      "leagueRank" : "19",
      "wildCardRank" : "4",
      "row" : 1,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "losses",
        "streakNumber" : 1,
        "streakCode" : "L1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 5,
        "name" : "Pittsburgh Penguins",
        "link" : "/api/v1/teams/5"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 1,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 11,
      "goalsScored" : 8,
      "points" : 2,
      "divisionRank" : "7",
      "conferenceRank" : "13",
      "leagueRank" : "23",
      "wildCardRank" : "7",
      "row" : 1,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "losses",
        "streakNumber" : 1,
        "streakCode" : "L1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 3,
        "name" : "New York Rangers",
        "link" : "/api/v1/teams/3"
      },
      "leagueRecord" : {
        "wins" : 0,
        "losses" : 3,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 14,
      "goalsScored" : 8,
      "points" : 0,
      "divisionRank" : "8",
      "conferenceRank" : "16",
      "leagueRank" : "31",
      "wildCardRank" : "10",
      "row" : 0,
      "gamesPlayed" : 3,
      "streak" : {
        "streakType" : "losses",
        "streakNumber" : 3,
        "streakCode" : "L3"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    } ]
  }, {
    "standingsType" : "regularSeason",
    "league" : {
      "id" : 133,
      "name" : "National Hockey League",
      "link" : "/api/v1/league/133"
    },
    "division" : {
      "id" : 17,
      "name" : "Atlantic",
      "nameShort" : "ATL",
      "link" : "/api/v1/divisions/17",
      "abbreviation" : "A"
    },
    "conference" : {
      "id" : 6,
      "name" : "Eastern",
      "link" : "/api/v1/conferences/6"
    },
    "teamRecords" : [ {
      "team" : {
        "id" : 10,
        "name" : "Toronto Maple Leafs",
        "link" : "/api/v1/teams/10"
      },
      "leagueRecord" : {
        "wins" : 2,
        "losses" : 1,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 13,
      "goalsScored" : 13,
      "points" : 4,
      "divisionRank" : "1",
      "conferenceRank" : "2",
      "leagueRank" : "7",
      "wildCardRank" : "0",
      "row" : 2,
      "gamesPlayed" : 3,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 1,
        "streakCode" : "W1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 8,
        "name" : "Montréal Canadiens",
        "link" : "/api/v1/teams/8"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 0,
        "ot" : 1,
        "type" : "league"
      },
      "goalsAgainst" : 4,
      "goalsScored" : 7,
      "points" : 3,
      "divisionRank" : "2",
      "conferenceRank" : "4",
      "leagueRank" : "9",
      "wildCardRank" : "0",
      "row" : 1,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 1,
        "streakCode" : "W1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 9,
        "name" : "Ottawa Senators",
        "link" : "/api/v1/teams/9"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 0,
        "ot" : 1,
        "type" : "league"
      },
      "goalsAgainst" : 7,
      "goalsScored" : 8,
      "points" : 3,
      "divisionRank" : "3",
      "conferenceRank" : "5",
      "leagueRank" : "11",
      "wildCardRank" : "0",
      "row" : 1,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 1,
        "streakCode" : "W1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 14,
        "name" : "Tampa Bay Lightning",
        "link" : "/api/v1/teams/14"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 0,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 1,
      "goalsScored" : 2,
      "points" : 2,
      "divisionRank" : "4",
      "conferenceRank" : "7",
      "leagueRank" : "13",
      "wildCardRank" : "1",
      "row" : 0,
      "gamesPlayed" : 1,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 1,
        "streakCode" : "W1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 7,
        "name" : "Buffalo Sabres",
        "link" : "/api/v1/teams/7"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 1,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 5,
      "goalsScored" : 3,
      "points" : 2,
      "divisionRank" : "5",
      "conferenceRank" : "11",
      "leagueRank" : "20",
      "wildCardRank" : "5",
      "row" : 1,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 1,
        "streakCode" : "W1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 6,
        "name" : "Boston Bruins",
        "link" : "/api/v1/teams/6"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 1,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 7,
      "goalsScored" : 4,
      "points" : 2,
      "divisionRank" : "6",
      "conferenceRank" : "12",
      "leagueRank" : "22",
      "wildCardRank" : "6",
      "row" : 1,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 1,
        "streakCode" : "W1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 13,
        "name" : "Florida Panthers",
        "link" : "/api/v1/teams/13"
      },
      "leagueRecord" : {
        "wins" : 0,
        "losses" : 0,
        "ot" : 1,
        "type" : "league"
      },
      "goalsAgainst" : 2,
      "goalsScored" : 1,
      "points" : 1,
      "divisionRank" : "7",
      "conferenceRank" : "14",
      "leagueRank" : "25",
      "wildCardRank" : "8",
      "row" : 0,
      "gamesPlayed" : 1,
      "streak" : {
        "streakType" : "ot",
        "streakNumber" : 1,
        "streakCode" : "OT1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 17,
        "name" : "Detroit Red Wings",
        "link" : "/api/v1/teams/17"
      },
      "leagueRecord" : {
        "wins" : 0,
        "losses" : 1,
        "ot" : 1,
        "type" : "league"
      },
      "goalsAgainst" : 7,
      "goalsScored" : 4,
      "points" : 1,
      "divisionRank" : "8",
      "conferenceRank" : "15",
      "leagueRank" : "26",
      "wildCardRank" : "9",
      "row" : 0,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "losses",
        "streakNumber" : 1,
        "streakCode" : "L1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    } ]
  }, {
    "standingsType" : "regularSeason",
    "league" : {
      "id" : 133,
      "name" : "National Hockey League",
      "link" : "/api/v1/league/133"
    },
    "division" : {
      "id" : 16,
      "name" : "Central",
      "nameShort" : "CEN",
      "link" : "/api/v1/divisions/16",
      "abbreviation" : "C"
    },
    "conference" : {
      "id" : 5,
      "name" : "Western",
      "link" : "/api/v1/conferences/5"
    },
    "teamRecords" : [ {
      "team" : {
        "id" : 16,
        "name" : "Chicago Blackhawks",
        "link" : "/api/v1/teams/16"
      },
      "leagueRecord" : {
        "wins" : 2,
        "losses" : 0,
        "ot" : 1,
        "type" : "league"
      },
      "goalsAgainst" : 14,
      "goalsScored" : 15,
      "points" : 5,
      "divisionRank" : "1",
      "conferenceRank" : "1",
      "leagueRank" : "2",
      "wildCardRank" : "0",
      "row" : 2,
      "gamesPlayed" : 3,
      "streak" : {
        "streakType" : "ot",
        "streakNumber" : 1,
        "streakCode" : "OT1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 25,
        "name" : "Dallas Stars",
        "link" : "/api/v1/teams/25"
      },
      "leagueRecord" : {
        "wins" : 2,
        "losses" : 0,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 1,
      "goalsScored" : 8,
      "points" : 4,
      "divisionRank" : "2",
      "conferenceRank" : "2",
      "leagueRank" : "3",
      "wildCardRank" : "0",
      "row" : 2,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 2,
        "streakCode" : "W2"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 21,
        "name" : "Colorado Avalanche",
        "link" : "/api/v1/teams/21"
      },
      "leagueRecord" : {
        "wins" : 2,
        "losses" : 0,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 3,
      "goalsScored" : 9,
      "points" : 4,
      "divisionRank" : "3",
      "conferenceRank" : "3",
      "leagueRank" : "4",
      "wildCardRank" : "0",
      "row" : 2,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 2,
        "streakCode" : "W2"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 18,
        "name" : "Nashville Predators",
        "link" : "/api/v1/teams/18"
      },
      "leagueRecord" : {
        "wins" : 2,
        "losses" : 0,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 5,
      "goalsScored" : 7,
      "points" : 4,
      "divisionRank" : "4",
      "conferenceRank" : "5",
      "leagueRank" : "6",
      "wildCardRank" : "1",
      "row" : 2,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 2,
        "streakCode" : "W2"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 52,
        "name" : "Winnipeg Jets",
        "link" : "/api/v1/teams/52"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 1,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 6,
      "goalsScored" : 6,
      "points" : 2,
      "divisionRank" : "5",
      "conferenceRank" : "9",
      "leagueRank" : "18",
      "wildCardRank" : "3",
      "row" : 1,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "losses",
        "streakNumber" : 1,
        "streakCode" : "L1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 30,
        "name" : "Minnesota Wild",
        "link" : "/api/v1/teams/30"
      },
      "leagueRecord" : {
        "wins" : 0,
        "losses" : 1,
        "ot" : 1,
        "type" : "league"
      },
      "goalsAgainst" : 6,
      "goalsScored" : 2,
      "points" : 1,
      "divisionRank" : "6",
      "conferenceRank" : "12",
      "leagueRank" : "27",
      "wildCardRank" : "6",
      "row" : 0,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "ot",
        "streakNumber" : 1,
        "streakCode" : "OT1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 19,
        "name" : "St. Louis Blues",
        "link" : "/api/v1/teams/19"
      },
      "leagueRecord" : {
        "wins" : 0,
        "losses" : 1,
        "ot" : 1,
        "type" : "league"
      },
      "goalsAgainst" : 10,
      "goalsScored" : 5,
      "points" : 1,
      "divisionRank" : "7",
      "conferenceRank" : "13",
      "leagueRank" : "28",
      "wildCardRank" : "7",
      "row" : 0,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "ot",
        "streakNumber" : 1,
        "streakCode" : "OT1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    } ]
  }, {
    "standingsType" : "regularSeason",
    "league" : {
      "id" : 133,
      "name" : "National Hockey League",
      "link" : "/api/v1/league/133"
    },
    "division" : {
      "id" : 15,
      "name" : "Pacific",
      "nameShort" : "PAC",
      "link" : "/api/v1/divisions/15",
      "abbreviation" : "P"
    },
    "conference" : {
      "id" : 5,
      "name" : "Western",
      "link" : "/api/v1/conferences/5"
    },
    "teamRecords" : [ {
      "team" : {
        "id" : 24,
        "name" : "Anaheim Ducks",
        "link" : "/api/v1/teams/24"
      },
      "leagueRecord" : {
        "wins" : 2,
        "losses" : 0,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 2,
      "goalsScored" : 6,
      "points" : 4,
      "divisionRank" : "1",
      "conferenceRank" : "4",
      "leagueRank" : "5",
      "wildCardRank" : "0",
      "row" : 2,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 2,
        "streakCode" : "W2"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 26,
        "name" : "Los Angeles Kings",
        "link" : "/api/v1/teams/26"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 0,
        "ot" : 1,
        "type" : "league"
      },
      "goalsAgainst" : 5,
      "goalsScored" : 6,
      "points" : 3,
      "divisionRank" : "2",
      "conferenceRank" : "6",
      "leagueRank" : "10",
      "wildCardRank" : "0",
      "row" : 1,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 1,
        "streakCode" : "W1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 20,
        "name" : "Calgary Flames",
        "link" : "/api/v1/teams/20"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 1,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 9,
      "goalsScored" : 9,
      "points" : 2,
      "divisionRank" : "3",
      "conferenceRank" : "7",
      "leagueRank" : "14",
      "wildCardRank" : "0",
      "row" : 1,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 1,
        "streakCode" : "W1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 23,
        "name" : "Vancouver Canucks",
        "link" : "/api/v1/teams/23"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 1,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 9,
      "goalsScored" : 9,
      "points" : 2,
      "divisionRank" : "4",
      "conferenceRank" : "8",
      "leagueRank" : "17",
      "wildCardRank" : "2",
      "row" : 1,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "losses",
        "streakNumber" : 1,
        "streakCode" : "L1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 28,
        "name" : "San Jose Sharks",
        "link" : "/api/v1/teams/28"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 1,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 7,
      "goalsScored" : 5,
      "points" : 2,
      "divisionRank" : "5",
      "conferenceRank" : "10",
      "leagueRank" : "21",
      "wildCardRank" : "4",
      "row" : 1,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 1,
        "streakCode" : "W1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 54,
        "name" : "Vegas Golden Knights",
        "link" : "/api/v1/teams/54"
      },
      "leagueRecord" : {
        "wins" : 1,
        "losses" : 1,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 6,
      "goalsScored" : 4,
      "points" : 2,
      "divisionRank" : "6",
      "conferenceRank" : "11",
      "leagueRank" : "24",
      "wildCardRank" : "5",
      "row" : 0,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "wins",
        "streakNumber" : 1,
        "streakCode" : "W1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 22,
        "name" : "Edmonton Oilers",
        "link" : "/api/v1/teams/22"
      },
      "leagueRecord" : {
        "wins" : 0,
        "losses" : 1,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 5,
      "goalsScored" : 2,
      "points" : 0,
      "divisionRank" : "7",
      "conferenceRank" : "14",
      "leagueRank" : "29",
      "wildCardRank" : "8",
      "row" : 0,
      "gamesPlayed" : 1,
      "streak" : {
        "streakType" : "losses",
        "streakNumber" : 1,
        "streakCode" : "L1"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    }, {
      "team" : {
        "id" : 53,
        "name" : "Arizona Coyotes",
        "link" : "/api/v1/teams/53"
      },
      "leagueRecord" : {
        "wins" : 0,
        "losses" : 2,
        "ot" : 0,
        "type" : "league"
      },
      "goalsAgainst" : 4,
      "goalsScored" : 0,
      "points" : 0,
      "divisionRank" : "8",
      "conferenceRank" : "15",
      "leagueRank" : "30",
      "wildCardRank" : "9",
      "row" : 0,
      "gamesPlayed" : 2,
      "streak" : {
        "streakType" : "losses",
        "streakNumber" : 2,
        "streakCode" : "L2"
      },
      "lastUpdated" : "2018-10-08T10:52:36Z"
    } ]
  } ]
}""">

type PlayerStats = JsonProvider<"""
{
  "copyright" : "NHL and the NHL Shield are registered trademarks of the National Hockey League. NHL and NHL team marks are the property of the NHL and its teams. © NHL 2018. All Rights Reserved.",
  "stats" : [ {
    "type" : {
      "displayName" : "statsSingleSeason"
    },
    "splits" : [ {
      "season" : "20182019",
      "stat" : {
        "timeOnIce" : "23:34",
        "assists" : 2,
        "goals" : 0,
        "pim" : 0,
        "shots" : 2,
        "games" : 1,
        "hits" : 0,
        "powerPlayGoals" : 0,
        "powerPlayPoints" : 1,
        "powerPlayTimeOnIce" : "04:17",
        "evenTimeOnIce" : "19:17",
        "penaltyMinutes" : "0",
        "faceOffPct" : 66.66,
        "shotPct" : 0.0,
        "gameWinningGoals" : 0,
        "overTimeGoals" : 0,
        "shortHandedGoals" : 0,
        "shortHandedPoints" : 0,
        "shortHandedTimeOnIce" : "00:00",
        "blocked" : 0,
        "plusMinus" : 0,
        "points" : 2,
        "shifts" : 25,
        "timeOnIcePerGame" : "23:34",
        "evenTimeOnIcePerGame" : "19:17",
        "shortHandedTimeOnIcePerGame" : "00:00",
        "powerPlayTimeOnIcePerGame" : "04:17"
      }
    } ]
  } ]
}""">