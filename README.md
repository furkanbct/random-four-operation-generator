# Unity Random Four Operation Generator
![Repo Size](https://img.shields.io/github/repo-size/furkanbct/5simGetCheapestCountries)
![Views](https://hits.seeyoufarm.com/api/count/incr/badge.svg?url=https://github.com/furkanbct/5simGetCheapestCountries&title=Views)
## About
This code generates random operation and 3 wrong options suitable to operation based on the difficulty and game mode you give
## Usage

* ```OperationManager.GetNewOperation(25, OperationManager.Mode.Addition)``` ----- Generates addition operation involving numbers from 1 to 25 etc. ```16 + 25 = ?```

* ```OperationManager.GetNewOperation(10, OperationManager.Mode.Multiplication, OperationManager.Mode.Division)``` ----- Generates division or multiplication operation involving numbers from 1 to 10 etc. ```9 ÷ 3 = ?```,```10 x 8 = ?```
