# PlayMaker FSM Documentation

## Environment details

| Property                   | Value                            |
| -------------------------- | -------------------------------- |
| productName                | BLUE PRINCE                      |
| companyName                | Dogubomb                         |
| version                    | 1.1.2.0                          |
| buildGUID                  | 11e47cebc96e7ca4e8a54ba03573e90d |
| unityVersion               | 2021.3.45f1                      |
| PlayMaker Assembly Version | 1.6.0.0                          |

## LOCKED DOORS ENGINE

| Property        | Value                                |
| --------------- | ------------------------------------ |
| PMDUuid         | aebe93e0-e3b7-56e8-901d-0193638a72ad |
| Active          | False                                |
| ActiveStateName |                                      |
| enabled         | False                                |
| FsmDescription  |                                      |
| FsmName         | FSM                                  |
| FullPath        | /__SYSTEM/LOCKED DOORS ENGINE        |

## Variables

| Name                  | Value | Type          |
| --------------------- | ----- | ------------- |
| day                   | 0     | FsmInt        |
| lock                  | False | FsmBool       |
| CURRENT LOCKED ENGINE | null  | FsmGameObject |
| active child          | null  | FsmGameObject |

## Events

| Name     | Path           |
| -------- | -------------- |
| Begin    |                |
| 1        |                |
| 2        |                |
| 3        |                |
| 0        |                |
| FINISHED | System Events/ |
| -1       |                |
| 4        |                |

## State 0: State 1

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 0 State 1: Transitions

| EventName | ToState   |
| --------- | --------- |
| FINISHED  | Late Days |

### 0 State 1: Actions

#### Action: 0-0 Wait

General Action Details:

| Property     | Value |
| ------------ | ----- |
| ActionIndex  | 0     |
| Type         | Wait  |
| BlocksFinish | True  |
| Enabled      | True  |

Wait Details:

| Property                | Value     |
| ----------------------- | --------- |
| time                    | 10        |
| finishEvent.Name        | FINISHED  |
| finishEvent.targetState | Late Days |
| realTime                | False     |
| startTime               | 0         |
| timer                   | 0         |

## State 1: Set Rank 3 - average

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 1 Set Rank 3 - average: Transitions

| EventName | ToState |
| --------- | ------- |
| FINISHED  | State 5 |

### 1 Set Rank 3 - average: Actions

#### Action: 1-0 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 0            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 5 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 1-1 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 1            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 5 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 1-2 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 2            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 5 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 1-3 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 3            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 5 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 1-4 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 4            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 5 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 1-5 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 5            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 5 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 1-6 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 6            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 5 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 1-7 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 7            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 5 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 1-8 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 8            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 5 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 1-9 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 9            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 5 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

## State 2: Early Day

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 2 Early Day: Transitions

| EventName | ToState              |
| --------- | -------------------- |
| 1         | Set Rank 3 - average |
| 2         | Rank 3 open          |

### 2 Early Day: Actions

#### Action: 2-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 5 BOOLS                       |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 2-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 5 BOOLS                       |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 2-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 5 BOOLS                       |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

## State 3: Set Rank 3 - Early

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 3 Set Rank 3 - Early: Transitions

| EventName | ToState |
| --------- | ------- |
| FINISHED  | State 5 |

### 3 Set Rank 3 - Early: Actions

#### Action: 3-0 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 0            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-1 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 1            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-2 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 2            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-3 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 3            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-4 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 4            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-5 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 5            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-6 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 6            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-7 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 7            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-8 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 8            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-9 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 9            |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-10 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 10           |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-11 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 11           |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-12 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 12           |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-13 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 13           |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-14 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 14           |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-15 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 15           |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-16 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 16           |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

#### Action: 3-17 ArrayListGet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 17           |
| Type         | ArrayListGet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListGet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| result.Type            | Bool                          |
| result.Value           | False                         |
| result.variableName    | lock                          |

## State 4: Rank 3 open

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 4 Rank 3 open: Transitions

| EventName | ToState |
| --------- | ------- |
| FINISHED  | State 3 |

## State 5: Set Rank 3 - Double

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 5 Set Rank 3 - Double: Transitions

| EventName | ToState |
| --------- | ------- |
| FINISHED  | State 4 |

### 5 Set Rank 3 - Double: Actions

#### Action: 5-0 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 0            |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-1 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 1            |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-2 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 2            |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-3 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 3            |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-4 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 4            |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-5 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 5            |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-6 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 6            |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-7 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 7            |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-8 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 8            |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-9 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 9            |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-10 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 10           |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-11 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 11           |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-12 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 12           |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-13 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 13           |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-14 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 14           |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-15 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 15           |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-16 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 16           |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-17 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 17           |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-18 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 18           |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

#### Action: 5-19 ArrayListSet

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 19           |
| Type         | ArrayListSet |
| BlocksFinish | True         |
| Enabled      | True         |

ArrayListSet Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| atIndex                | 0                             |
| everyFrame             | False                         |
| forceResizeIdNeeded    | False                         |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 9 BOOLS                       |
| variable.Type          | Bool                          |
| variable.Value         | False                         |
| variable.variableName  |                               |

## State 6: Late Days

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 6 Late Days: Transitions

| EventName | ToState              |
| --------- | -------------------- |
| 0         | Set Rank 3 - Double  |
| 1         | Set Rank 3 - Early   |
| 2         | Set Rank 3 - average |
| 3         | Rank 3 open          |
| -1        | Early Day            |

### 6 Late Days: Actions

#### Action: 6-0 GetFsmInt

General Action Details:

| Property     | Value     |
| ------------ | --------- |
| ActionIndex  | 0         |
| Type         | GetFsmInt |
| BlocksFinish | True      |
| Enabled      | True      |

GetFsmInt Details:

| Property               | Value             |
| ---------------------- | ----------------- |
| everyFrame             | False             |
| fsmName                | FSM               |
| gameObject.OwnerOption | SpecifyGameObject |
| gameObject.FullPath    | /DAY              |
| storeValue             | 0                 |
| storeValue.Name        | day               |
| variableName           | Day               |

#### Action: 6-1 GetFsmInt

General Action Details:

| Property     | Value     |
| ------------ | --------- |
| ActionIndex  | 1         |
| Type         | GetFsmInt |
| BlocksFinish | True      |
| Enabled      | True      |

GetFsmInt Details:

| Property               | Value             |
| ---------------------- | ----------------- |
| everyFrame             | False             |
| fsmName                | FSM               |
| gameObject.OwnerOption | SpecifyGameObject |
| gameObject.FullPath    | /DAY              |
| storeValue             | 0                 |
| storeValue.Name        | day               |
| variableName           | Day               |

#### Action: 6-2 GetFsmInt

General Action Details:

| Property     | Value     |
| ------------ | --------- |
| ActionIndex  | 2         |
| Type         | GetFsmInt |
| BlocksFinish | True      |
| Enabled      | True      |

GetFsmInt Details:

| Property               | Value             |
| ---------------------- | ----------------- |
| everyFrame             | False             |
| fsmName                | FSM               |
| gameObject.OwnerOption | SpecifyGameObject |
| gameObject.FullPath    | /DAY              |
| storeValue             | 0                 |
| storeValue.Name        | day               |
| variableName           | Day               |

#### Action: 6-3 GetFsmInt

General Action Details:

| Property     | Value     |
| ------------ | --------- |
| ActionIndex  | 3         |
| Type         | GetFsmInt |
| BlocksFinish | True      |
| Enabled      | True      |

GetFsmInt Details:

| Property               | Value             |
| ---------------------- | ----------------- |
| everyFrame             | False             |
| fsmName                | FSM               |
| gameObject.OwnerOption | SpecifyGameObject |
| gameObject.FullPath    | /DAY              |
| storeValue             | 0                 |
| storeValue.Name        | day               |
| variableName           | Day               |

#### Action: 6-4 GetFsmInt

General Action Details:

| Property     | Value     |
| ------------ | --------- |
| ActionIndex  | 4         |
| Type         | GetFsmInt |
| BlocksFinish | True      |
| Enabled      | True      |

GetFsmInt Details:

| Property               | Value             |
| ---------------------- | ----------------- |
| everyFrame             | False             |
| fsmName                | FSM               |
| gameObject.OwnerOption | SpecifyGameObject |
| gameObject.FullPath    | /DAY              |
| storeValue             | 0                 |
| storeValue.Name        | day               |
| variableName           | Day               |

## State 7: Set Rank 4 - One Lock

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 7 Set Rank 4 - One Lock: Transitions

| EventName | ToState |
| --------- | ------- |
| FINISHED  | State 7 |

### 7 Set Rank 4 - One Lock: Actions

#### Action: 7-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-3 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 3                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-4 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 4                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-5 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 5                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-6 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 6                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-7 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 7                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-8 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 8                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-9 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 9                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-10 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 10               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-11 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 11               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-12 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 12               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-13 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 13               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-14 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 14               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-15 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 15               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-16 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 16               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-17 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 17               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-18 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 18               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

## State 8: Rank 4 open

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 8 Rank 4 open: Transitions

| EventName | ToState |
| --------- | ------- |
| FINISHED  | State 6 |

## State 9: Set Rank 4 - Triple

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 9 Set Rank 4 - Triple: Transitions

| EventName | ToState |
| --------- | ------- |
| FINISHED  | State 8 |

### 9 Set Rank 4 - Triple: Actions

#### Action: 9-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-3 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 3                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-4 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 4                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-5 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 5                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-6 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 6                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-7 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 7                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-8 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 8                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-9 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 9                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-10 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 10               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-11 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 11               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-12 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 12               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-13 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 13               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-14 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 14               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-15 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 15               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-16 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 16               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-17 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 17               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-18 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 18               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

## State 10: State 3

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 10 State 3: Transitions

| EventName | ToState               |
| --------- | --------------------- |
| 1         | Set Rank 4 - Triple   |
| 2         | Set Rank 4 - One Lock |

### 10 State 3: Actions

#### Action: 10-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event | Target State          |
| ------ | ----- | --------------------- |
| 0.3    | 1     | Set Rank 4 - Triple   |
| 0.7    | 2     | Set Rank 4 - One Lock |

## State 11: State 4

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 11 State 4: Transitions

| EventName | ToState               |
| --------- | --------------------- |
| 1         | Set Rank 4 - One Lock |
| 2         | Rank 4 open           |

### 11 State 4: Actions

#### Action: 11-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event | Target State          |
| ------ | ----- | --------------------- |
| 0.4    | 1     | Set Rank 4 - One Lock |
| 0.6    | 2     | Rank 4 open           |

## State 12: State 5

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 12 State 5: Transitions

| EventName | ToState               |
| --------- | --------------------- |
| 1         | Set Rank 4 - Triple   |
| 2         | Set Rank 4 - Average  |
| 3         | Set Rank 4 - One Lock |
| 4         | Rank 4 open           |

### 12 State 5: Actions

#### Action: 12-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event | Target State          |
| ------ | ----- | --------------------- |
| 0.15   | 1     | Set Rank 4 - Triple   |
| 0.4    | 2     | Set Rank 4 - Average  |
| 0.3    | 3     | Set Rank 4 - One Lock |
| 0.05   | 4     | Rank 4 open           |

## State 13: Set Rank 5 - average

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 13 Set Rank 5 - average: Transitions

| EventName | ToState  |
| --------- | -------- |
| FINISHED  | State 10 |

### 13 Set Rank 5 - average: Actions

#### Action: 13-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-3 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 3                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-4 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 4                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-5 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 5                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-6 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 6                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-7 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 7                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-8 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 8                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-9 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 9                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-10 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 10               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-11 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 11               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-12 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 12               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-13 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 13               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-14 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 14               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

## State 14: Set Rank 4 - Average

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 14 Set Rank 4 - Average: Transitions

| EventName | ToState |
| --------- | ------- |
| FINISHED  | State 7 |

### 14 Set Rank 4 - Average: Actions

#### Action: 14-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-3 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 3                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-4 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 4                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-5 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 5                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-6 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 6                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-7 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 7                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-8 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 8                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-9 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 9                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-10 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 10               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-11 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 11               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-12 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 12               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-13 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 13               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-14 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 14               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-15 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 15               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-16 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 16               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-17 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 17               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-18 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 18               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

## State 15: Set Rank 5 - Kinda Open

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 15 Set Rank 5 - Kinda Open: Transitions

| EventName | ToState |
| --------- | ------- |
| FINISHED  | State 9 |

### 15 Set Rank 5 - Kinda Open: Actions

#### Action: 15-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-3 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 3                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-4 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 4                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-5 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 5                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-6 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 6                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-7 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 7                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-8 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 8                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-9 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 9                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-10 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 10               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-11 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 11               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-12 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 12               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-13 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 13               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-14 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 14               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

## State 16: Set Rank 5 - Heavy Lock

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 16 Set Rank 5 - Heavy Lock: Transitions

| EventName | ToState  |
| --------- | -------- |
| FINISHED  | State 11 |

### 16 Set Rank 5 - Heavy Lock: Actions

#### Action: 16-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-3 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 3                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-4 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 4                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-5 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 5                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-6 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 6                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-7 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 7                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-8 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 8                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-9 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 9                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-10 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 10               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-11 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 11               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-12 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 12               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-13 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 13               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-14 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 14               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

## State 17: State 6

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 17 State 6: Transitions

| EventName | ToState                 |
| --------- | ----------------------- |
| 1         | Set Rank 5 - Heavy Lock |
| 2         | Set Rank 5 - average    |

### 17 State 6: Actions

#### Action: 17-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event | Target State            |
| ------ | ----- | ----------------------- |
| 0.5    | 1     | Set Rank 5 - Heavy Lock |
| 0.5    | 2     | Set Rank 5 - average    |

## State 18: State 7

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 18 State 7: Transitions

| EventName | ToState                 |
| --------- | ----------------------- |
| 1         | Set Rank 5 - Heavy Lock |
| 2         | Set Rank 5 - average    |
| 3         | Set Rank 5 - Kinda Open |

### 18 State 7: Actions

#### Action: 18-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event | Target State            |
| ------ | ----- | ----------------------- |
| 0.1    | 1     | Set Rank 5 - Heavy Lock |
| 0.6    | 2     | Set Rank 5 - average    |
| 0.3    | 3     | Set Rank 5 - Kinda Open |

## State 19: State 8

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 19 State 8: Transitions

| EventName | ToState                 |
| --------- | ----------------------- |
| 1         | Set Rank 5 - average    |
| 2         | Set Rank 5 - Kinda Open |

### 19 State 8: Actions

#### Action: 19-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event | Target State            |
| ------ | ----- | ----------------------- |
| 0.5    | 1     | Set Rank 5 - average    |
| 0.5    | 2     | Set Rank 5 - Kinda Open |

## State 20: Set Rank 6 - Average 2

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 20 Set Rank 6 - Average 2: Transitions

| EventName | ToState  |
| --------- | -------- |
| FINISHED  | State 12 |

### 20 Set Rank 6 - Average 2: Actions

#### Action: 20-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-3 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 3                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-4 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 4                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-5 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 5                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-6 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 6                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-7 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 7                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-8 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 8                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-9 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 9                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-10 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 10               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-11 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 11               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-12 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 12               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-13 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 13               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-14 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 14               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-15 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 15               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-16 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 16               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-17 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 17               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-18 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 18               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

## State 21: Set Rank 6 - Locked

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 21 Set Rank 6 - Locked: Transitions

| EventName | ToState  |
| --------- | -------- |
| FINISHED  | State 12 |

### 21 Set Rank 6 - Locked: Actions

#### Action: 21-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-3 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 3                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-4 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 4                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-5 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 5                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-6 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 6                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-7 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 7                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-8 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 8                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-9 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 9                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-10 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 10               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-11 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 11               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-12 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 12               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-13 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 13               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-14 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 14               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-15 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 15               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-16 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 16               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-17 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 17               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-18 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 18               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

## State 22: Set Rank 6 - Open

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 22 Set Rank 6 - Open: Transitions

| EventName | ToState              |
| --------- | -------------------- |
| FINISHED  | Set Rank 7 - Average |

### 22 Set Rank 6 - Open: Actions

#### Action: 22-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-3 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 3                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-4 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 4                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-5 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 5                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-6 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 6                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-7 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 7                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-8 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 8                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-9 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 9                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-10 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 10               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-11 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 11               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-12 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 12               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-13 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 13               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-14 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 14               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-15 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 15               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-16 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 16               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-17 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 17               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-18 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 18               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

## State 23: State 9

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 23 State 9: Transitions

| EventName | ToState                |
| --------- | ---------------------- |
| 1         | Set Rank 6 - Locked    |
| 2         | Set Rank 6 - Average 2 |

### 23 State 9: Actions

#### Action: 23-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event | Target State           |
| ------ | ----- | ---------------------- |
| 0.2    | 1     | Set Rank 6 - Locked    |
| 0.8    | 2     | Set Rank 6 - Average 2 |

## State 24: State 10

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 24 State 10: Transitions

| EventName | ToState                |
| --------- | ---------------------- |
| 1         | Set Rank 6 - Locked    |
| 2         | Set Rank 6 - Average 2 |
| 3         | Set Rank 6 - Open      |

### 24 State 10: Actions

#### Action: 24-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event | Target State           |
| ------ | ----- | ---------------------- |
| 0.1    | 1     | Set Rank 6 - Locked    |
| 0.8    | 2     | Set Rank 6 - Average 2 |
| 0.1    | 3     | Set Rank 6 - Open      |

## State 25: State 11

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 25 State 11: Transitions

| EventName | ToState                |
| --------- | ---------------------- |
| 1         | Set Rank 6 - Average 2 |
| 2         | Set Rank 6 - Open      |

### 25 State 11: Actions

#### Action: 25-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event | Target State           |
| ------ | ----- | ---------------------- |
| 0.5    | 1     | Set Rank 6 - Average 2 |
| 0.5    | 2     | Set Rank 6 - Open      |

## State 26: Set Rank 7 - Average

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 26 Set Rank 7 - Average: Transitions

| EventName | ToState  |
| --------- | -------- |
| FINISHED  | State 13 |

### 26 Set Rank 7 - Average: Actions

#### Action: 26-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-3 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 3                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-4 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 4                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-5 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 5                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-6 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 6                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-7 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 7                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-8 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 8                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-9 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 9                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-10 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 10               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-11 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 11               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-12 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 12               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-13 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 13               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-14 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 14               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-15 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 15               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-16 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 16               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-17 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 17               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-18 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 18               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

## State 27: Set Rank 7 - Open

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 27 Set Rank 7 - Open: Transitions

| EventName | ToState                 |
| --------- | ----------------------- |
| FINISHED  | Set Rank 8 - One Unlock |

### 27 Set Rank 7 - Open: Actions

#### Action: 27-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-3 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 3                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-4 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 4                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-5 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 5                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-6 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 6                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-7 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 7                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-8 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 8                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-9 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 9                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-10 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 10               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-11 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 11               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-12 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 12               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-13 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 13               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-14 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 14               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-15 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 15               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-16 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 16               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-17 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 17               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-18 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 18               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

## State 28: State 12

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 28 State 12: Transitions

| EventName | ToState              |
| --------- | -------------------- |
| 1         | Set Rank 7 - Average |
| 2         | Set Rank 7 - Open    |

### 28 State 12: Actions

#### Action: 28-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event | Target State         |
| ------ | ----- | -------------------- |
| 0.5    | 1     | Set Rank 7 - Average |
| 0.5    | 2     | Set Rank 7 - Open    |

## State 29: Set Rank 8 - One Unlock

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 29 Set Rank 8 - One Unlock: Transitions

| EventName | ToState  |
| --------- | -------- |
| FINISHED  | State 14 |

### 29 Set Rank 8 - One Unlock: Actions

#### Action: 29-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-3 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 3                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-4 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 4                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-5 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 5                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-6 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 6                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-7 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 7                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-8 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 8                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-9 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 9                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-10 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 10               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-11 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 11               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-12 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 12               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-13 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 13               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-14 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 14               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-15 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 15               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-16 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 16               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-17 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 17               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-18 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 18               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

## State 30: Set Rank 8 - Two Unlocks

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 30 Set Rank 8 - Two Unlocks: Transitions

| EventName | ToState  |
| --------- | -------- |
| FINISHED  | State 14 |

### 30 Set Rank 8 - Two Unlocks: Actions

#### Action: 30-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-3 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 3                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-4 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 4                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-5 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 5                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-6 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 6                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-7 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 7                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-8 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 8                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-9 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 9                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-10 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 10               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-11 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 11               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-12 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 12               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-13 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 13               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-14 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 14               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-15 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 15               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-16 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 16               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-17 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 17               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-18 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 18               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

## State 31: State 13

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 31 State 13: Transitions

| EventName | ToState                  |
| --------- | ------------------------ |
| 1         | Set Rank 8 - One Unlock  |
| 2         | Set Rank 8 - Two Unlocks |

### 31 State 13: Actions

#### Action: 31-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event | Target State             |
| ------ | ----- | ------------------------ |
| 0.6    | 1     | Set Rank 8 - One Unlock  |
| 0.4    | 2     | Set Rank 8 - Two Unlocks |

## State 32: State 14

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 32 State 14: Transitions

| EventName | ToState                 |
| --------- | ----------------------- |
| 1         | All Locked              |
| 2         | Set Rank 9 - One Unlock |

### 32 State 14: Actions

#### Action: 32-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event | Target State            |
| ------ | ----- | ----------------------- |
| 0.97   | 1     | All Locked              |
| 0.03   | 2     | Set Rank 9 - One Unlock |

## State 33: Set Rank 9 - One Unlock

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 33 Set Rank 9 - One Unlock: Transitions

| EventName | ToState |
| --------- | ------- |
| FINISHED  | Done    |

### 33 Set Rank 9 - One Unlock: Actions

#### Action: 33-0 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 9                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 33-1 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 9                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 33-2 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 2                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 9                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 33-3 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 3                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 9                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 33-4 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 4                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 9                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 33-5 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 5                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 9                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 33-6 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 6                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 9                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 33-7 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 7                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 9                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 33-8 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 8                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 9                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 33-9 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 9                |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 9                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 33-10 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 10               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 9                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 33-11 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 11               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 9                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 33-12 ArrayListShuffle

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 12               |
| Type         | ArrayListShuffle |
| BlocksFinish | True             |
| Enabled      | True             |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.OwnerOption | UseOwner                      |
| gameObject.FullPath    | /__SYSTEM/LOCKED DOORS ENGINE |
| reference              | Rank 9                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

## State 34: All Locked

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 34 All Locked: Transitions

| EventName | ToState |
| --------- | ------- |
| FINISHED  | Done    |

## State 35: Done

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

