# Unity Random Four Operation Generator
## About
This code generates random operation and 3 wrong options suitable to operation based on the difficulty and game mode you give
## Usage

* ```OperationManager.GetNewOperation(25, OperationManager.Mode.Addiction)``` ----- Generates addiction operation involving numbers from 1 to 25 etc. ```16 + 25 = ?```

* ```OperationManager.GetNewOperation(10, OperationManager.Mode.Multiplication, OperationManager.Mode.Division)``` ----- Generates division or multiplication operation involving numbers from 1 to 10 etc. ```9 ÷ 3 = ?```,```10 x 8 = ?```
