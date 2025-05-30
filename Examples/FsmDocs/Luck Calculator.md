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

## Luck Calculator

| Property        | Value                     |
| --------------- | ------------------------- |
| Active          | True                      |
| ActiveStateName | Item Spawn                |
| enabled         | True                      |
| FsmDescription  |                           |
| FsmName         | Luck Calculator           |
| FullPath        | /__SYSTEM/Luck Calculator |

## Variables

| Name               | Value | Type          |
| ------------------ | ----- | ------------- |
| AvgLuck - Bad      | 0.8   | FsmFloat      |
| AvgLuck - Good     | 0.2   | FsmFloat      |
| BalanceSubtraction | 0     | FsmInt        |
| DropTarget         | 2     | FsmInt        |
| Greenhouse Rank    | 100   | FsmInt        |
| LUCK               | 999   | FsmInt        |
| Target RANK        | 0     | FsmInt        |
| TempLuck           | 0     | FsmInt        |
| This Room's Luck   | 0     | FsmInt        |
| Veranda Luck Bonus | 0     | FsmInt        |
| Upgrade Int        | 0     | FsmInt        |
| dows luck          | 0     | FsmInt        |
| Is Green?          | False | FsmBool       |
| One time Luck Proc | False | FsmBool       |
| dowse              | False | FsmBool       |
| Current Pickup     | null  | FsmGameObject |
| Current Engine     | null  | FsmGameObject |

## Events

| Name             | Path           |
| ---------------- | -------------- |
| FINISHED         | System Events/ |
| Avg Luck         |                |
| Bad Luck         |                |
| DOWSED           |                |
| Extremely Lucky  |                |
| Items Go         |                |
| Kinda Lucky      |                |
| Luck Calculator  |                |
| Lucky            |                |
| Very Lucky       |                |
| cont             |                |
| skip             |                |
| 2                |                |
| 1                |                |
| 0                |                |

## State 0: Luck Check

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 0 Luck Check: Transitions

| EventName       | ToState             |
| --------------- | ------------------- |
| Bad Luck        | Set Bad Luck 2      |
| Avg Luck        | Set  Avg Luck 2     |
| Kinda Lucky     | Set  Kinda Lucky 2  |
| Lucky           | Set Lucky 2         |
| Very Lucky      | 2 Items Guarenteed! |
| Extremely Lucky | 3 Items Guarenteed! |
| FINISHED        | 4 out of 4          |

### 0 Luck Check: Actions

#### Action: 0-0 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 0          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property             | Value          |
| -------------------- | -------------- |
| integer1             | 0              |
| integer2             | 5              |
| everyFrame           | False          |
| lessThan.Name        | Bad Luck       |
| lessThan.targetState | Set Bad Luck 2 |

#### Action: 0-1 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 1          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property             | Value          |
| -------------------- | -------------- |
| integer1             | 0              |
| integer2             | 5              |
| everyFrame           | False          |
| lessThan.Name        | Bad Luck       |
| lessThan.targetState | Set Bad Luck 2 |

#### Action: 0-2 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 2          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property             | Value          |
| -------------------- | -------------- |
| integer1             | 0              |
| integer2             | 5              |
| everyFrame           | False          |
| lessThan.Name        | Bad Luck       |
| lessThan.targetState | Set Bad Luck 2 |

#### Action: 0-3 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 3          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property             | Value          |
| -------------------- | -------------- |
| integer1             | 0              |
| integer2             | 5              |
| everyFrame           | False          |
| lessThan.Name        | Bad Luck       |
| lessThan.targetState | Set Bad Luck 2 |

#### Action: 0-4 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 4          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property             | Value          |
| -------------------- | -------------- |
| integer1             | 0              |
| integer2             | 5              |
| everyFrame           | False          |
| lessThan.Name        | Bad Luck       |
| lessThan.targetState | Set Bad Luck 2 |

#### Action: 0-5 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 5          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property             | Value          |
| -------------------- | -------------- |
| integer1             | 0              |
| integer2             | 5              |
| everyFrame           | False          |
| lessThan.Name        | Bad Luck       |
| lessThan.targetState | Set Bad Luck 2 |

## State 1: Item Spawn

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 1 Item Spawn: Transitions

| EventName        | ToState       |
| ---------------- | ------------- |
| Luck Calculator  | Dowsing Check |

## State 2: Loop Back

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 2 Loop Back: Transitions

| EventName | ToState    |
| --------- | ---------- |
| FINISHED  | Item Spawn |

### 2 Loop Back: Actions

#### Action: 2-0 Wait

General Action Details:

| Property     | Value |
| ------------ | ----- |
| ActionIndex  | 0     |
| Type         | Wait  |
| BlocksFinish | True  |
| Enabled      | True  |
| Name         |       |

Wait Details:

| Property                | Value      |
| ----------------------- | ---------- |
| time                    | 0.02       |
| finishEvent.Name        | FINISHED   |
| finishEvent.targetState | Item Spawn |
| realTime                | False      |
| startTime               | 0          |
| timer                   | 0          |

## State 3: VERANDA Check

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 3 VERANDA Check: Transitions

| EventName | ToState                |
| --------- | ---------------------- |
| FINISHED  | Luck Balance Modifiers |

### 3 VERANDA Check: Actions

#### Action: 3-0 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 0          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property          | Value                  |
| ----------------- | ---------------------- |
| integer1          | 0                      |
| integer2          | 0                      |
| equal.Name        | FINISHED               |
| equal.targetState | Luck Balance Modifiers |
| everyFrame        | False                  |

#### Action: 3-1 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 1          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property          | Value                  |
| ----------------- | ---------------------- |
| integer1          | 0                      |
| integer2          | 0                      |
| equal.Name        | FINISHED               |
| equal.targetState | Luck Balance Modifiers |
| everyFrame        | False                  |

#### Action: 3-2 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 2          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property          | Value                  |
| ----------------- | ---------------------- |
| integer1          | 0                      |
| integer2          | 0                      |
| equal.Name        | FINISHED               |
| equal.targetState | Luck Balance Modifiers |
| everyFrame        | False                  |

#### Action: 3-3 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 3          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property          | Value                  |
| ----------------- | ---------------------- |
| integer1          | 0                      |
| integer2          | 0                      |
| equal.Name        | FINISHED               |
| equal.targetState | Luck Balance Modifiers |
| everyFrame        | False                  |

## State 4: Set Bad Luck 2

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 4 Set Bad Luck 2: Transitions

| EventName | ToState          |
| --------- | ---------------- |
| Bad Luck  | 0 Items          |
| Avg Luck  | Dowse Correction |

### 4 Set Bad Luck 2: Actions

#### Action: 4-0 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 0           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

#### Action: 4-1 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 1           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

## State 5: Set  Avg Luck 2

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 5 Set  Avg Luck 2: Transitions

| EventName | ToState            |
| --------- | ------------------ |
| Bad Luck  | 0 Items            |
| Lucky     | 1 Item Guarenteed! |

### 5 Set  Avg Luck 2: Actions

#### Action: 5-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |
| Name         |                 |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event    | Target State       |
| ------ | -------- | ------------------ |
| 0.8    | Bad Luck | 0 Items            |
| 0.2    | Lucky    | 1 Item Guarenteed! |

## State 6: Set  Kinda Lucky 2

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 6 Set  Kinda Lucky 2: Transitions

| EventName | ToState            |
| --------- | ------------------ |
| Bad Luck  | 0 Items            |
| Lucky     | 1 Item Guarenteed! |

### 6 Set  Kinda Lucky 2: Actions

#### Action: 6-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |
| Name         |                 |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event    | Target State       |
| ------ | -------- | ------------------ |
| 0.6    | Bad Luck | 0 Items            |
| 0.4    | Lucky    | 1 Item Guarenteed! |

## State 7: Set Lucky 2

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 7 Set Lucky 2: Transitions

| EventName | ToState            |
| --------- | ------------------ |
| Bad Luck  | 0 Items            |
| Lucky     | 1 Item Guarenteed! |

### 7 Set Lucky 2: Actions

#### Action: 7-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |
| Name         |                 |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event    | Target State       |
| ------ | -------- | ------------------ |
| 0.2    | Bad Luck | 0 Items            |
| 0.8    | Lucky    | 1 Item Guarenteed! |

## State 8: 3 Items Guarenteed!

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 8 3 Items Guarenteed!: Transitions

| EventName | ToState          |
| --------- | ---------------- |
| FINISHED  | Send Drop Target |

### 8 3 Items Guarenteed!: Actions

#### Action: 8-0 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 0           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

#### Action: 8-1 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 1           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

#### Action: 8-2 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 2           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

#### Action: 8-3 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 3           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

## State 9: 4 out of 4

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 9 4 out of 4: Transitions

| EventName | ToState          |
| --------- | ---------------- |
| FINISHED  | Send Drop Target |

### 9 4 out of 4: Actions

#### Action: 9-0 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 0           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

#### Action: 9-1 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 1           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

## State 10: 1 Item Guarenteed!

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 10 1 Item Guarenteed!: Transitions

| EventName  | ToState             |
| ---------- | ------------------- |
| Avg Luck   | Dowse Correction    |
| Very Lucky | 2 Items Guarenteed! |

### 10 1 Item Guarenteed!: Actions

#### Action: 10-0 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 0           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

#### Action: 10-1 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 1           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

## State 11: 2 Items Guarenteed!

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 11 2 Items Guarenteed!: Transitions

| EventName  | ToState             |
| ---------- | ------------------- |
| Avg Luck   | Send Drop Target    |
| Very Lucky | 3 Items Guarenteed! |

### 11 2 Items Guarenteed!: Actions

#### Action: 11-0 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 0           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

#### Action: 11-1 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 1           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

#### Action: 11-2 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 2           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

#### Action: 11-3 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 3           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

#### Action: 11-4 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 4           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

## State 12: 0 Items

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 12 0 Items: Transitions

| EventName | ToState          |
| --------- | ---------------- |
| FINISHED  | Dowse Correction |

### 12 0 Items: Actions

#### Action: 12-0 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 0           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

## State 13: Send Drop Target

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 13 Send Drop Target: Transitions

| EventName | ToState   |
| --------- | --------- |
| FINISHED  | Loop Back |

### 13 Send Drop Target: Actions

#### Action: 13-0 SetBoolValue

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 0            |
| Type         | SetBoolValue |
| BlocksFinish | True         |
| Enabled      | False        |
| Name         |              |

#### Action: 13-1 SetBoolValue

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 1            |
| Type         | SetBoolValue |
| BlocksFinish | True         |
| Enabled      | False        |
| Name         |              |

#### Action: 13-2 SetBoolValue

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 2            |
| Type         | SetBoolValue |
| BlocksFinish | True         |
| Enabled      | False        |
| Name         |              |

## State 14: Rabbit's Foot

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 14 Rabbit's Foot: Transitions

| EventName | ToState       |
| --------- | ------------- |
| cont      | +3            |
| skip      | VERANDA Check |

### 14 Rabbit's Foot: Actions

#### Action: 14-0 ArrayListContains

General Action Details:

| Property     | Value             |
| ------------ | ----------------- |
| ActionIndex  | 0                 |
| Type         | ArrayListContains |
| BlocksFinish | True              |
| Enabled      | True              |
| Name         |                   |

#### Action: 14-1 ArrayListContains

General Action Details:

| Property     | Value             |
| ------------ | ----------------- |
| ActionIndex  | 1                 |
| Type         | ArrayListContains |
| BlocksFinish | True              |
| Enabled      | True              |
| Name         |                   |

## State 15: +3

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 15 +3: Transitions

| EventName | ToState       |
| --------- | ------------- |
| FINISHED  | VERANDA Check |

### 15 +3: Actions

#### Action: 15-0 IntAdd

General Action Details:

| Property     | Value  |
| ------------ | ------ |
| ActionIndex  | 0      |
| Type         | IntAdd |
| BlocksFinish | True   |
| Enabled      | True   |
| Name         |        |

## State 16: SET INT LUCK

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 16 SET INT LUCK: Transitions

| EventName | ToState       |
| --------- | ------------- |
| FINISHED  | Rabbit's Foot |

### 16 SET INT LUCK: Actions

#### Action: 16-0 SetIntValue

General Action Details:

| Property     | Value       |
| ------------ | ----------- |
| ActionIndex  | 0           |
| Type         | SetIntValue |
| BlocksFinish | True        |
| Enabled      | True        |
| Name         |             |

## State 17: Set Dowsed Luck

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 17 Set Dowsed Luck: Transitions

| EventName | ToState       |
| --------- | ------------- |
| FINISHED  | Rabbit's Foot |

### 17 Set Dowsed Luck: Actions

#### Action: 17-0 SetBoolValue

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 0            |
| Type         | SetBoolValue |
| BlocksFinish | True         |
| Enabled      | True         |
| Name         |              |

#### Action: 17-1 SetBoolValue

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 1            |
| Type         | SetBoolValue |
| BlocksFinish | True         |
| Enabled      | True         |
| Name         |              |

#### Action: 17-2 SetBoolValue

General Action Details:

| Property     | Value        |
| ------------ | ------------ |
| ActionIndex  | 2            |
| Type         | SetBoolValue |
| BlocksFinish | True         |
| Enabled      | True         |
| Name         |              |

## State 18: Dowse Correction

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 18 Dowse Correction: Transitions

| EventName | ToState          |
| --------- | ---------------- |
| skip      | Send Drop Target |
| FINISHED  | Send Drop Target |

### 18 Dowse Correction: Actions

#### Action: 18-0 BoolTest

General Action Details:

| Property     | Value    |
| ------------ | -------- |
| ActionIndex  | 0        |
| Type         | BoolTest |
| BlocksFinish | True     |
| Enabled      | True     |
| Name         |          |

#### Action: 18-1 BoolTest

General Action Details:

| Property     | Value    |
| ------------ | -------- |
| ActionIndex  | 1        |
| Type         | BoolTest |
| BlocksFinish | True     |
| Enabled      | True     |
| Name         |          |

## State 19: Luck Balance Modifiers

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 19 Luck Balance Modifiers: Transitions

| EventName | ToState    |
| --------- | ---------- |
| FINISHED  | Luck Check |
| skip      | Dows Check |

### 19 Luck Balance Modifiers: Actions

#### Action: 19-0 BoolTest

General Action Details:

| Property     | Value    |
| ------------ | -------- |
| ActionIndex  | 0        |
| Type         | BoolTest |
| BlocksFinish | True     |
| Enabled      | True     |
| Name         |          |

#### Action: 19-1 BoolTest

General Action Details:

| Property     | Value    |
| ------------ | -------- |
| ActionIndex  | 1        |
| Type         | BoolTest |
| BlocksFinish | True     |
| Enabled      | True     |
| Name         |          |

## State 20: Dowsing Check

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 20 Dowsing Check: Transitions

| EventName | ToState         |
| --------- | --------------- |
| DOWSED    | Set Dowsed Luck |
| FINISHED  | SET INT LUCK    |

### 20 Dowsing Check: Actions

#### Action: 20-0 BoolTest

General Action Details:

| Property     | Value    |
| ------------ | -------- |
| ActionIndex  | 0        |
| Type         | BoolTest |
| BlocksFinish | True     |
| Enabled      | True     |
| Name         |          |

## State 21: Dowsing Rod

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 21 Dowsing Rod: Transitions

| EventName       | ToState            |
| --------------- | ------------------ |
| skip            | Luck Check         |
| Avg Luck        | 1 Item Guarenteed! |
| Very Lucky      | Dows +1            |
| Extremely Lucky | Dows +2            |

### 21 Dowsing Rod: Actions

#### Action: 21-0 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 0          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property             | Value      |
| -------------------- | ---------- |
| integer1             | 0          |
| integer2             | 19         |
| everyFrame           | False      |
| lessThan.Name        | skip       |
| lessThan.targetState | Luck Check |

#### Action: 21-1 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 1          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property             | Value      |
| -------------------- | ---------- |
| integer1             | 0          |
| integer2             | 19         |
| everyFrame           | False      |
| lessThan.Name        | skip       |
| lessThan.targetState | Luck Check |

#### Action: 21-2 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 2          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property             | Value      |
| -------------------- | ---------- |
| integer1             | 0          |
| integer2             | 19         |
| everyFrame           | False      |
| lessThan.Name        | skip       |
| lessThan.targetState | Luck Check |

## State 22: Check Dowsing Array

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 22 Check Dowsing Array: Transitions

| EventName | ToState             |
| --------- | ------------------- |
| 1         | Dowsing Rod         |
| 2         | 2 Items Guarenteed! |

### 22 Check Dowsing Array: Actions

#### Action: 22-0 GetFsmGameObject

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 0                |
| Type         | GetFsmGameObject |
| BlocksFinish | True             |
| Enabled      | True             |
| Name         |                  |

GetFsmGameObject Details:

| Property               | Value                               |
| ---------------------- | ----------------------------------- |
| everyFrame             | False                               |
| fsmName                | FSM                                 |
| fsmNameLastFrame       | null                                |
| gameObject.OwnerOption | SpecifyGameObject                   |
| gameObject.FullPath    | /__SYSTEM/THE DRAFT/PLAN MANAGEMENT |
| storeValue             | null                                |
| variableName           | PLAN1 - ENGINE                      |

#### Action: 22-1 GetFsmGameObject

General Action Details:

| Property     | Value            |
| ------------ | ---------------- |
| ActionIndex  | 1                |
| Type         | GetFsmGameObject |
| BlocksFinish | True             |
| Enabled      | True             |
| Name         |                  |

GetFsmGameObject Details:

| Property               | Value                               |
| ---------------------- | ----------------------------------- |
| everyFrame             | False                               |
| fsmName                | FSM                                 |
| fsmNameLastFrame       | null                                |
| gameObject.OwnerOption | SpecifyGameObject                   |
| gameObject.FullPath    | /__SYSTEM/THE DRAFT/PLAN MANAGEMENT |
| storeValue             | null                                |
| variableName           | PLAN1 - ENGINE                      |

## State 23: Dows +1

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 23 Dows +1: Transitions

| EventName | ToState             |
| --------- | ------------------- |
| FINISHED  | 3 Items Guarenteed! |

### 23 Dows +1: Actions

#### Action: 23-0 IntAdd

General Action Details:

| Property     | Value  |
| ------------ | ------ |
| ActionIndex  | 0      |
| Type         | IntAdd |
| BlocksFinish | True   |
| Enabled      | True   |
| Name         |        |

## State 24: Dows +2

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 24 Dows +2: Transitions

| EventName | ToState    |
| --------- | ---------- |
| FINISHED  | 4 out of 4 |

### 24 Dows +2: Actions

#### Action: 24-0 IntAdd

General Action Details:

| Property     | Value  |
| ------------ | ------ |
| ActionIndex  | 0      |
| Type         | IntAdd |
| BlocksFinish | True   |
| Enabled      | True   |
| Name         |        |

## State 25: Dows Check

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | True  |
| maxLoopCount   | 0     |

### 25 Dows Check: Transitions

| EventName | ToState             |
| --------- | ------------------- |
| 0         | State 2             |
| 1         | State 1             |
| FINISHED  | Check Dowsing Array |

### 25 Dows Check: Actions

#### Action: 25-0 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 0          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property                | Value   |
| ----------------------- | ------- |
| integer1                | 0       |
| integer2                | 5       |
| everyFrame              | False   |
| greaterThan.Name        | 0       |
| greaterThan.targetState | State 2 |

#### Action: 25-1 IntCompare

General Action Details:

| Property     | Value      |
| ------------ | ---------- |
| ActionIndex  | 1          |
| Type         | IntCompare |
| BlocksFinish | True       |
| Enabled      | True       |
| Name         |            |

IntCompare Details:

| Property                | Value   |
| ----------------------- | ------- |
| integer1                | 0       |
| integer2                | 5       |
| everyFrame              | False   |
| greaterThan.Name        | 0       |
| greaterThan.targetState | State 2 |

## State 26: State 1

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 26 State 1: Transitions

| EventName  | ToState             |
| ---------- | ------------------- |
| Avg Luck   | State 2             |
| Very Lucky | Check Dowsing Array |
| Bad Luck   | 1 Item Guarenteed!  |

### 26 State 1: Actions

#### Action: 26-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |
| Name         |                 |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event      | Target State        |
| ------ | ---------- | ------------------- |
| 0.2    | Bad Luck   | 1 Item Guarenteed!  |
| 0.6    | Avg Luck   | State 2             |
| 0.2    | Very Lucky | Check Dowsing Array |

## State 27: State 2

| Property       | Value |
| -------------- | ----- |
| Description    |       |
| HandlesOnEvent | False |
| IsSequence     | False |
| maxLoopCount   | 0     |

### 27 State 2: Transitions

| EventName | ToState             |
| --------- | ------------------- |
| Avg Luck  | 2 Items Guarenteed! |
| Bad Luck  | 1 Item Guarenteed!  |

### 27 State 2: Actions

#### Action: 27-0 SendRandomEvent

General Action Details:

| Property     | Value           |
| ------------ | --------------- |
| ActionIndex  | 0               |
| Type         | SendRandomEvent |
| BlocksFinish | True            |
| Enabled      | True            |
| Name         |                 |

SendRandomEvent Details:

| Name  | Value |
| ----- | ----- |
| delay | 0     |

| Weight | Event    | Target State        |
| ------ | -------- | ------------------- |
| 0.5    | Bad Luck | 1 Item Guarenteed!  |
| 0.5    | Avg Luck | 2 Items Guarenteed! |

