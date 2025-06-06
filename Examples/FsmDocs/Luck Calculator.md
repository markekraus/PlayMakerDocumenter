# /__SYSTEM/Luck Calculator

## Environment details

| Property                 | Value                            |
| ------------------------ | -------------------------------- |
| BuildGUID                | 11e47cebc96e7ca4e8a54ba03573e90d |
| CompanyName              | Dogubomb                         |
| PlayMakerAssemblyVersion | 1.6.0.0                          |
| ProductName              | BLUE PRINCE                      |
| UnityVersion             | 2021.3.45f1                      |
| Version                  | 1.1.2.0                          |

## FSM Details

| Property        | Value                                |
| --------------- | ------------------------------------ |
| Active          | True                                 |
| ActiveStateName | Item Spawn                           |
| Enabled         | True                                 |
| FsmDescription  |                                      |
| FsmName         | Luck Calculator                      |
| FullPath        | /__SYSTEM/Luck Calculator            |
| StateCount      | 28                                   |
| Uuid            | ad6348da-8c1c-507c-84ce-44eab94355ab |

## Variables

| Name               | Value | Type          |
| ------------------ | ----- | ------------- |
| AvgLuck - Bad      | 0.8   | FsmFloat      |
| AvgLuck - Good     | 0.2   | FsmFloat      |
| BalanceSubtraction | 0     | FsmInt        |
| Current Engine     | null  | FsmGameObject |
| Current Pickup     | null  | FsmGameObject |
| dows luck          | 0     | FsmInt        |
| dowse              | False | FsmBool       |
| DropTarget         | 2     | FsmInt        |
| Greenhouse Rank    | 100   | FsmInt        |
| Is Green?          | False | FsmBool       |
| LUCK               | 999   | FsmInt        |
| One time Luck Proc | False | FsmBool       |
| Target RANK        | 0     | FsmInt        |
| TempLuck           | 0     | FsmInt        |
| This Room's Luck   | 0     | FsmInt        |
| Upgrade Int        | 0     | FsmInt        |
| Veranda Luck Bonus | 0     | FsmInt        |

## Events

| Name             | Path           |
| ---------------- | -------------- |
| 0                | null           |
| 1                | null           |
| 2                | null           |
| Avg Luck         | null           |
| Bad Luck         | null           |
| cont             | null           |
| DOWSED           | null           |
| Extremely Lucky  | null           |
| FINISHED         | System Events/ |
| Items Go         | null           |
| Kinda Lucky      | null           |
| Luck Calculator  | null           |
| Lucky            | null           |
| skip             | null           |
| Very Lucky       | null           |

## State 0: Luck Check

| Property       | Value      |
| -------------- | ---------- |
| ActionCount    | 6          |
| Description    |            |
| HandlesOnEvent | False      |
| MaxLoopCount   | 0          |
| Name           | Luck Check |
| StateIndex     | 0          |

### 0 Luck Check: Transitions

| EventName       | ToFsmState          |
| --------------- | ------------------- |
| Avg Luck        | Set  Avg Luck 2     |
| Bad Luck        | Set Bad Luck 2      |
| Extremely Lucky | 3 Items Guarenteed! |
| FINISHED        | 4 out of 4          |
| Kinda Lucky     | Set  Kinda Lucky 2  |
| Lucky           | Set Lucky 2         |
| Very Lucky      | 2 Items Guarenteed! |

### 0 Luck Check: Actions

#### Action: 0-0 IntCompare

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 0                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 0                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntCompare |
| TypeName     | IntCompare                                     |

IntCompare Details:

| Property             | Value          |
| -------------------- | -------------- |
| equal                | null           |
| everyFrame           | False          |
| greaterThan          | null           |
| integer1             | 0              |
| integer2             | 5              |
| lessThan.Name        | Bad Luck       |
| lessThan.targetState | Set Bad Luck 2 |

#### Action: 0-1 IntCompare

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 1                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 0                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntCompare |
| TypeName     | IntCompare                                     |

IntCompare Details:

| Property             | Value           |
| -------------------- | --------------- |
| equal                | null            |
| everyFrame           | False           |
| greaterThan          | null            |
| integer1             | 0               |
| integer2             | 11              |
| lessThan.Name        | Avg Luck        |
| lessThan.targetState | Set  Avg Luck 2 |

#### Action: 0-2 IntCompare

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 0                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntCompare |
| TypeName     | IntCompare                                     |

IntCompare Details:

| Property             | Value              |
| -------------------- | ------------------ |
| equal                | null               |
| everyFrame           | False              |
| greaterThan          | null               |
| integer1             | 0                  |
| integer2             | 16                 |
| lessThan.Name        | Kinda Lucky        |
| lessThan.targetState | Set  Kinda Lucky 2 |

#### Action: 0-3 IntCompare

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 3                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 0                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntCompare |
| TypeName     | IntCompare                                     |

IntCompare Details:

| Property             | Value       |
| -------------------- | ----------- |
| equal                | null        |
| everyFrame           | False       |
| greaterThan          | null        |
| integer1             | 0           |
| integer2             | 19          |
| lessThan.Name        | Lucky       |
| lessThan.targetState | Set Lucky 2 |

#### Action: 0-4 IntCompare

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 0                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntCompare |
| TypeName     | IntCompare                                     |

IntCompare Details:

| Property             | Value               |
| -------------------- | ------------------- |
| equal                | null                |
| everyFrame           | False               |
| greaterThan          | null                |
| integer1             | 0                   |
| integer2             | 23                  |
| lessThan.Name        | Very Lucky          |
| lessThan.targetState | 2 Items Guarenteed! |

#### Action: 0-5 IntCompare

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 5                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 0                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntCompare |
| TypeName     | IntCompare                                     |

IntCompare Details:

| Property             | Value               |
| -------------------- | ------------------- |
| equal                | null                |
| everyFrame           | False               |
| greaterThan          | null                |
| integer1             | 0                   |
| integer2             | 29                  |
| lessThan.Name        | Extremely Lucky     |
| lessThan.targetState | 3 Items Guarenteed! |

## State 1: Item Spawn

| Property       | Value      |
| -------------- | ---------- |
| ActionCount    | 0          |
| Description    |            |
| HandlesOnEvent | False      |
| MaxLoopCount   | 0          |
| Name           | Item Spawn |
| StateIndex     | 1          |

### 1 Item Spawn: Transitions

| EventName        | ToFsmState    |
| ---------------- | ------------- |
| Luck Calculator  | Dowsing Check |

## State 2: Loop Back

| Property       | Value     |
| -------------- | --------- |
| ActionCount    | 1         |
| Description    |           |
| HandlesOnEvent | False     |
| MaxLoopCount   | 0         |
| Name           | Loop Back |
| StateIndex     | 2         |

### 2 Loop Back: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | Item Spawn |

### 2 Loop Back: Actions

#### Action: 2-0 Wait

General Action Details:

| Property     | Value                                    |
| ------------ | ---------------------------------------- |
| ActionIndex  | 0                                        |
| BlockFinish  | True                                     |
| Enabled      | True                                     |
| Name         |                                          |
| StateIndex   | 2                                        |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.Wait |
| TypeName     | Wait                                     |

Wait Details:

| Property                | Value      |
| ----------------------- | ---------- |
| finishEvent.Name        | FINISHED   |
| finishEvent.targetState | Item Spawn |
| realTime                | False      |
| startTime               | 0          |
| time                    | 0.02       |
| timer                   | 0          |

## State 3: VERANDA Check

| Property       | Value         |
| -------------- | ------------- |
| ActionCount    | 4             |
| Description    |               |
| HandlesOnEvent | False         |
| MaxLoopCount   | 0             |
| Name           | VERANDA Check |
| StateIndex     | 3             |

### 3 VERANDA Check: Transitions

| EventName | ToFsmState             |
| --------- | ---------------------- |
| FINISHED  | Luck Balance Modifiers |

### 3 VERANDA Check: Actions

#### Action: 3-0 IntCompare

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 0                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 3                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntCompare |
| TypeName     | IntCompare                                     |

IntCompare Details:

| Property          | Value                  |
| ----------------- | ---------------------- |
| equal.Name        | FINISHED               |
| equal.targetState | Luck Balance Modifiers |
| everyFrame        | False                  |
| greaterThan       | null                   |
| integer1          | 0                      |
| integer2          | 0                      |
| lessThan          | null                   |

#### Action: 3-1 BoolTest

General Action Details:

| Property     | Value                                        |
| ------------ | -------------------------------------------- |
| ActionIndex  | 1                                            |
| BlockFinish  | True                                         |
| Enabled      | True                                         |
| Name         |                                              |
| StateIndex   | 3                                            |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.BoolTest |
| TypeName     | BoolTest                                     |

BoolTest Details:

| Property            | Value                  |
| ------------------- | ---------------------- |
| boolVariable        | False                  |
| everyFrame          | False                  |
| isFalse.Name        | FINISHED               |
| isFalse.targetState | Luck Balance Modifiers |
| isTrue              | null                   |

#### Action: 3-2 IntAdd

General Action Details:

| Property     | Value                                      |
| ------------ | ------------------------------------------ |
| ActionIndex  | 2                                          |
| BlockFinish  | True                                       |
| Enabled      | True                                       |
| Name         |                                            |
| StateIndex   | 3                                          |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntAdd |
| TypeName     | IntAdd                                     |

IntAdd Details:

| Property    | Value |
| ----------- | ----- |
| add         | 0     |
| everyFrame  | False |
| intVariable | 0     |

#### Action: 3-3 SetBoolValue

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 3                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetBoolValue |
| TypeName     | SetBoolValue                                     |

SetBoolValue Details:

| Property     | Value |
| ------------ | ----- |
| boolValue    | False |
| boolVariable | False |
| everyFrame   | False |

## State 4: Set Bad Luck 2

| Property       | Value          |
| -------------- | -------------- |
| ActionCount    | 2              |
| Description    |                |
| HandlesOnEvent | False          |
| MaxLoopCount   | 0              |
| Name           | Set Bad Luck 2 |
| StateIndex     | 4              |

### 4 Set Bad Luck 2: Transitions

| EventName | ToFsmState       |
| --------- | ---------------- |
| Avg Luck  | Dowse Correction |
| Bad Luck  | 0 Items          |

### 4 Set Bad Luck 2: Actions

#### Action: 4-0 SetIntValue

General Action Details:

| Property     | Value                                           |
| ------------ | ----------------------------------------------- |
| ActionIndex  | 0                                               |
| BlockFinish  | True                                            |
| Enabled      | True                                            |
| Name         |                                                 |
| StateIndex   | 4                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetIntValue |
| TypeName     | SetIntValue                                     |

SetIntValue Details:

| Property    | Value |
| ----------- | ----- |
| everyFrame  | False |
| intValue    | 1     |
| intVariable | 2     |

#### Action: 4-1 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 1                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 4                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                       |
| --------------------- | ------------------------------------------- |
| delay                 | 0                                           |
| delayedEvent          | null                                        |
| events.Count          | 2                                           |
| events[0].Name        | Avg Luck                                    |
| events[0].targetState | Dowse Correction                            |
| events[1].Name        | Bad Luck                                    |
| events[1].targetState | 0 Items                                     |
| weight: 0.07          | Event: 'Avg Luck' State: 'Dowse Correction' |
| weight: 0.93          | Event: 'Bad Luck' State: '0 Items'          |
| weights.Count         | 2                                           |
| weights[0]            | 0.07                                        |
| weights[1]            | 0.93                                        |

## State 5: Set  Avg Luck 2

| Property       | Value           |
| -------------- | --------------- |
| ActionCount    | 1               |
| Description    |                 |
| HandlesOnEvent | False           |
| MaxLoopCount   | 0               |
| Name           | Set  Avg Luck 2 |
| StateIndex     | 5               |

### 5 Set  Avg Luck 2: Transitions

| EventName | ToFsmState         |
| --------- | ------------------ |
| Bad Luck  | 0 Items            |
| Lucky     | 1 Item Guarenteed! |

### 5 Set  Avg Luck 2: Actions

#### Action: 5-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 5                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                      |
| --------------------- | ------------------------------------------ |
| delay                 | 0                                          |
| delayedEvent          | null                                       |
| events.Count          | 2                                          |
| events[0].Name        | Bad Luck                                   |
| events[0].targetState | 0 Items                                    |
| events[1].Name        | Lucky                                      |
| events[1].targetState | 1 Item Guarenteed!                         |
| weight: 0.2           | Event: 'Lucky' State: '1 Item Guarenteed!' |
| weight: 0.8           | Event: 'Bad Luck' State: '0 Items'         |
| weights.Count         | 2                                          |
| weights[0]            | 0.8                                        |
| weights[1]            | 0.2                                        |

## State 6: Set  Kinda Lucky 2

| Property       | Value              |
| -------------- | ------------------ |
| ActionCount    | 1                  |
| Description    |                    |
| HandlesOnEvent | False              |
| MaxLoopCount   | 0                  |
| Name           | Set  Kinda Lucky 2 |
| StateIndex     | 6                  |

### 6 Set  Kinda Lucky 2: Transitions

| EventName | ToFsmState         |
| --------- | ------------------ |
| Bad Luck  | 0 Items            |
| Lucky     | 1 Item Guarenteed! |

### 6 Set  Kinda Lucky 2: Actions

#### Action: 6-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 6                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                      |
| --------------------- | ------------------------------------------ |
| delay                 | 0                                          |
| delayedEvent          | null                                       |
| events.Count          | 2                                          |
| events[0].Name        | Bad Luck                                   |
| events[0].targetState | 0 Items                                    |
| events[1].Name        | Lucky                                      |
| events[1].targetState | 1 Item Guarenteed!                         |
| weight: 0.4           | Event: 'Lucky' State: '1 Item Guarenteed!' |
| weight: 0.6           | Event: 'Bad Luck' State: '0 Items'         |
| weights.Count         | 2                                          |
| weights[0]            | 0.6                                        |
| weights[1]            | 0.4                                        |

## State 7: Set Lucky 2

| Property       | Value       |
| -------------- | ----------- |
| ActionCount    | 1           |
| Description    |             |
| HandlesOnEvent | False       |
| MaxLoopCount   | 0           |
| Name           | Set Lucky 2 |
| StateIndex     | 7           |

### 7 Set Lucky 2: Transitions

| EventName | ToFsmState         |
| --------- | ------------------ |
| Bad Luck  | 0 Items            |
| Lucky     | 1 Item Guarenteed! |

### 7 Set Lucky 2: Actions

#### Action: 7-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 7                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                      |
| --------------------- | ------------------------------------------ |
| delay                 | 0                                          |
| delayedEvent          | null                                       |
| events.Count          | 2                                          |
| events[0].Name        | Bad Luck                                   |
| events[0].targetState | 0 Items                                    |
| events[1].Name        | Lucky                                      |
| events[1].targetState | 1 Item Guarenteed!                         |
| weight: 0.2           | Event: 'Bad Luck' State: '0 Items'         |
| weight: 0.8           | Event: 'Lucky' State: '1 Item Guarenteed!' |
| weights.Count         | 2                                          |
| weights[0]            | 0.2                                        |
| weights[1]            | 0.8                                        |

## State 8: 3 Items Guarenteed!

| Property       | Value               |
| -------------- | ------------------- |
| ActionCount    | 4                   |
| Description    |                     |
| HandlesOnEvent | False               |
| MaxLoopCount   | 0                   |
| Name           | 3 Items Guarenteed! |
| StateIndex     | 8                   |

### 8 3 Items Guarenteed!: Transitions

| EventName | ToFsmState       |
| --------- | ---------------- |
| FINISHED  | Send Drop Target |

### 8 3 Items Guarenteed!: Actions

#### Action: 8-0 SetIntValue

General Action Details:

| Property     | Value                                           |
| ------------ | ----------------------------------------------- |
| ActionIndex  | 0                                               |
| BlockFinish  | True                                            |
| Enabled      | True                                            |
| Name         |                                                 |
| StateIndex   | 8                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetIntValue |
| TypeName     | SetIntValue                                     |

SetIntValue Details:

| Property    | Value |
| ----------- | ----- |
| everyFrame  | False |
| intValue    | 2     |
| intVariable | 2     |

#### Action: 8-1 IntCompare

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 1                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 8                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntCompare |
| TypeName     | IntCompare                                     |

IntCompare Details:

| Property             | Value            |
| -------------------- | ---------------- |
| equal                | null             |
| everyFrame           | False            |
| greaterThan          | null             |
| integer1             | 0                |
| integer2             | 17               |
| lessThan.Name        | FINISHED         |
| lessThan.targetState | Send Drop Target |

#### Action: 8-2 SetIntValue

General Action Details:

| Property     | Value                                           |
| ------------ | ----------------------------------------------- |
| ActionIndex  | 2                                               |
| BlockFinish  | True                                            |
| Enabled      | True                                            |
| Name         |                                                 |
| StateIndex   | 8                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetIntValue |
| TypeName     | SetIntValue                                     |

SetIntValue Details:

| Property    | Value |
| ----------- | ----- |
| everyFrame  | False |
| intValue    | 3     |
| intVariable | 2     |

#### Action: 8-3 IntAdd

General Action Details:

| Property     | Value                                      |
| ------------ | ------------------------------------------ |
| ActionIndex  | 3                                          |
| BlockFinish  | True                                       |
| Enabled      | True                                       |
| Name         |                                            |
| StateIndex   | 8                                          |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntAdd |
| TypeName     | IntAdd                                     |

IntAdd Details:

| Property    | Value |
| ----------- | ----- |
| add         | -2    |
| everyFrame  | False |
| intVariable | 0     |

## State 9: 4 out of 4

| Property       | Value      |
| -------------- | ---------- |
| ActionCount    | 2          |
| Description    |            |
| HandlesOnEvent | False      |
| MaxLoopCount   | 0          |
| Name           | 4 out of 4 |
| StateIndex     | 9          |

### 9 4 out of 4: Transitions

| EventName | ToFsmState       |
| --------- | ---------------- |
| FINISHED  | Send Drop Target |

### 9 4 out of 4: Actions

#### Action: 9-0 SetIntValue

General Action Details:

| Property     | Value                                           |
| ------------ | ----------------------------------------------- |
| ActionIndex  | 0                                               |
| BlockFinish  | True                                            |
| Enabled      | True                                            |
| Name         |                                                 |
| StateIndex   | 9                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetIntValue |
| TypeName     | SetIntValue                                     |

SetIntValue Details:

| Property    | Value |
| ----------- | ----- |
| everyFrame  | False |
| intValue    | 4     |
| intVariable | 2     |

#### Action: 9-1 IntAdd

General Action Details:

| Property     | Value                                      |
| ------------ | ------------------------------------------ |
| ActionIndex  | 1                                          |
| BlockFinish  | True                                       |
| Enabled      | True                                       |
| Name         |                                            |
| StateIndex   | 9                                          |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntAdd |
| TypeName     | IntAdd                                     |

IntAdd Details:

| Property    | Value |
| ----------- | ----- |
| add         | -3    |
| everyFrame  | False |
| intVariable | 0     |

## State 10: 1 Item Guarenteed!

| Property       | Value              |
| -------------- | ------------------ |
| ActionCount    | 2                  |
| Description    |                    |
| HandlesOnEvent | False              |
| MaxLoopCount   | 0                  |
| Name           | 1 Item Guarenteed! |
| StateIndex     | 10                 |

### 10 1 Item Guarenteed!: Transitions

| EventName  | ToFsmState          |
| ---------- | ------------------- |
| Avg Luck   | Dowse Correction    |
| Very Lucky | 2 Items Guarenteed! |

### 10 1 Item Guarenteed!: Actions

#### Action: 10-0 SetIntValue

General Action Details:

| Property     | Value                                           |
| ------------ | ----------------------------------------------- |
| ActionIndex  | 0                                               |
| BlockFinish  | True                                            |
| Enabled      | True                                            |
| Name         |                                                 |
| StateIndex   | 10                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetIntValue |
| TypeName     | SetIntValue                                     |

SetIntValue Details:

| Property    | Value |
| ----------- | ----- |
| everyFrame  | False |
| intValue    | 1     |
| intVariable | 2     |

#### Action: 10-1 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 1                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 10                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                            |
| --------------------- | ------------------------------------------------ |
| delay                 | 0                                                |
| delayedEvent          | null                                             |
| events.Count          | 2                                                |
| events[0].Name        | Avg Luck                                         |
| events[0].targetState | Dowse Correction                                 |
| events[1].Name        | Very Lucky                                       |
| events[1].targetState | 2 Items Guarenteed!                              |
| weight: 0.04          | Event: 'Very Lucky' State: '2 Items Guarenteed!' |
| weight: 0.96          | Event: 'Avg Luck' State: 'Dowse Correction'      |
| weights.Count         | 2                                                |
| weights[0]            | 0.96                                             |
| weights[1]            | 0.04                                             |

## State 11: 2 Items Guarenteed!

| Property       | Value               |
| -------------- | ------------------- |
| ActionCount    | 5                   |
| Description    |                     |
| HandlesOnEvent | False               |
| MaxLoopCount   | 0                   |
| Name           | 2 Items Guarenteed! |
| StateIndex     | 11                  |

### 11 2 Items Guarenteed!: Transitions

| EventName  | ToFsmState          |
| ---------- | ------------------- |
| Avg Luck   | Send Drop Target    |
| Very Lucky | 3 Items Guarenteed! |

### 11 2 Items Guarenteed!: Actions

#### Action: 11-0 SetIntValue

General Action Details:

| Property     | Value                                           |
| ------------ | ----------------------------------------------- |
| ActionIndex  | 0                                               |
| BlockFinish  | True                                            |
| Enabled      | True                                            |
| Name         |                                                 |
| StateIndex   | 11                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetIntValue |
| TypeName     | SetIntValue                                     |

SetIntValue Details:

| Property    | Value |
| ----------- | ----- |
| everyFrame  | False |
| intValue    | 1     |
| intVariable | 2     |

#### Action: 11-1 IntCompare

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 1                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 11                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntCompare |
| TypeName     | IntCompare                                     |

IntCompare Details:

| Property             | Value            |
| -------------------- | ---------------- |
| equal                | null             |
| everyFrame           | False            |
| greaterThan          | null             |
| integer1             | 0                |
| integer2             | 11               |
| lessThan.Name        | Avg Luck         |
| lessThan.targetState | Send Drop Target |

#### Action: 11-2 SetIntValue

General Action Details:

| Property     | Value                                           |
| ------------ | ----------------------------------------------- |
| ActionIndex  | 2                                               |
| BlockFinish  | True                                            |
| Enabled      | True                                            |
| Name         |                                                 |
| StateIndex   | 11                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetIntValue |
| TypeName     | SetIntValue                                     |

SetIntValue Details:

| Property    | Value |
| ----------- | ----- |
| everyFrame  | False |
| intValue    | 2     |
| intVariable | 2     |

#### Action: 11-3 IntAdd

General Action Details:

| Property     | Value                                      |
| ------------ | ------------------------------------------ |
| ActionIndex  | 3                                          |
| BlockFinish  | True                                       |
| Enabled      | True                                       |
| Name         |                                            |
| StateIndex   | 11                                         |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntAdd |
| TypeName     | IntAdd                                     |

IntAdd Details:

| Property    | Value |
| ----------- | ----- |
| add         | -1    |
| everyFrame  | False |
| intVariable | 0     |

#### Action: 11-4 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 4                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 11                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                            |
| --------------------- | ------------------------------------------------ |
| delay                 | 0                                                |
| delayedEvent          | null                                             |
| events.Count          | 2                                                |
| events[0].Name        | Avg Luck                                         |
| events[0].targetState | Send Drop Target                                 |
| events[1].Name        | Very Lucky                                       |
| events[1].targetState | 3 Items Guarenteed!                              |
| weight: 0.05          | Event: 'Very Lucky' State: '3 Items Guarenteed!' |
| weight: 0.95          | Event: 'Avg Luck' State: 'Send Drop Target'      |
| weights.Count         | 2                                                |
| weights[0]            | 0.95                                             |
| weights[1]            | 0.05                                             |

## State 12: 0 Items

| Property       | Value   |
| -------------- | ------- |
| ActionCount    | 1       |
| Description    |         |
| HandlesOnEvent | False   |
| MaxLoopCount   | 0       |
| Name           | 0 Items |
| StateIndex     | 12      |

### 12 0 Items: Transitions

| EventName | ToFsmState       |
| --------- | ---------------- |
| FINISHED  | Dowse Correction |

### 12 0 Items: Actions

#### Action: 12-0 SetIntValue

General Action Details:

| Property     | Value                                           |
| ------------ | ----------------------------------------------- |
| ActionIndex  | 0                                               |
| BlockFinish  | True                                            |
| Enabled      | True                                            |
| Name         |                                                 |
| StateIndex   | 12                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetIntValue |
| TypeName     | SetIntValue                                     |

SetIntValue Details:

| Property    | Value |
| ----------- | ----- |
| everyFrame  | False |
| intValue    | 0     |
| intVariable | 2     |

## State 13: Send Drop Target

| Property       | Value            |
| -------------- | ---------------- |
| ActionCount    | 3                |
| Description    |                  |
| HandlesOnEvent | False            |
| MaxLoopCount   | 0                |
| Name           | Send Drop Target |
| StateIndex     | 13               |

### 13 Send Drop Target: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | Loop Back  |

### 13 Send Drop Target: Actions

#### Action: 13-0 SetBoolValue

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 0                                                |
| BlockFinish  | True                                             |
| Enabled      | False                                            |
| Name         |                                                  |
| StateIndex   | 13                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetBoolValue |
| TypeName     | SetBoolValue                                     |

SetBoolValue Details:

| Property     | Value |
| ------------ | ----- |
| boolValue    | False |
| boolVariable | False |
| everyFrame   | False |

#### Action: 13-1 SetFsmInt

General Action Details:

| Property     | Value                                         |
| ------------ | --------------------------------------------- |
| ActionIndex  | 1                                             |
| BlockFinish  | True                                          |
| Enabled      | True                                          |
| Name         |                                               |
| StateIndex   | 13                                            |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmInt |
| TypeName     | SetFsmInt                                     |

SetFsmInt Details:

| Property               | Value             |
| ---------------------- | ----------------- |
| everyFrame             | False             |
| fsm                    | null              |
| fsmName                | Go Items Random   |
| fsmNameLastFrame       | null              |
| gameObject.GameObject  | null              |
| gameObject.OwnerOption | SpecifyGameObject |
| goLastFrame            | null              |
| setValue               | 2                 |
| variableName           | DropTarget        |

#### Action: 13-2 SendEvent

General Action Details:

| Property     | Value                                         |
| ------------ | --------------------------------------------- |
| ActionIndex  | 2                                             |
| BlockFinish  | True                                          |
| Enabled      | True                                          |
| Name         |                                               |
| StateIndex   | 13                                            |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendEvent |
| TypeName     | SendEvent                                     |

SendEvent Details:

| Property                           | Value             |
| ---------------------------------- | ----------------- |
| delay                              | 0                 |
| delayedEvent                       | null              |
| eventTarget.excludeSelf            | False             |
| eventTarget.fsmComponent           | null              |
| eventTarget.fsmName                |                   |
| eventTarget.gameObject.GameObject  | null              |
| eventTarget.gameObject.OwnerOption | SpecifyGameObject |
| eventTarget.sendToChildren         | False             |
| eventTarget.target                 | GameObject        |
| everyFrame                         | False             |
| sendEvent.Name                     | Items Go          |
| sendEvent.targetState              | *Unknown*         |

## State 14: Rabbit's Foot

| Property       | Value         |
| -------------- | ------------- |
| ActionCount    | 2             |
| Description    |               |
| HandlesOnEvent | False         |
| MaxLoopCount   | 0             |
| Name           | Rabbit's Foot |
| StateIndex     | 14            |

### 14 Rabbit's Foot: Transitions

| EventName | ToFsmState    |
| --------- | ------------- |
| cont      | +3            |
| skip      | VERANDA Check |

### 14 Rabbit's Foot: Actions

#### Action: 14-0 ArrayListContains

General Action Details:

| Property     | Value                                                 |
| ------------ | ----------------------------------------------------- |
| ActionIndex  | 0                                                     |
| BlockFinish  | True                                                  |
| Enabled      | True                                                  |
| Name         |                                                       |
| StateIndex   | 14                                                    |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListContains |
| TypeName     | ArrayListContains                                     |

ArrayListContains Details:

| Property                     | Value                                    |
| ---------------------------- | ---------------------------------------- |
| gameObject.GameObject        | /__SYSTEM/Inventory/Inventory (PickedUp) |
| gameObject.OwnerOption       | SpecifyGameObject                        |
| indexResult                  | 0                                        |
| isContained                  | False                                    |
| isContainedEvent.Name        | cont                                     |
| isContainedEvent.targetState | +3                                       |
| isNotContainedEvent          | null                                     |
| reference                    |                                          |
| variable                     | Il2CppHutongGames.PlayMaker.FsmVar       |
| variable.Type                | GameObject                               |
| variable.variableName        |                                          |

#### Action: 14-1 ArrayListContains

General Action Details:

| Property     | Value                                                 |
| ------------ | ----------------------------------------------------- |
| ActionIndex  | 1                                                     |
| BlockFinish  | True                                                  |
| Enabled      | True                                                  |
| Name         |                                                       |
| StateIndex   | 14                                                    |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListContains |
| TypeName     | ArrayListContains                                     |

ArrayListContains Details:

| Property                        | Value                                    |
| ------------------------------- | ---------------------------------------- |
| gameObject.GameObject           | /__SYSTEM/Inventory/Inventory (PickedUp) |
| gameObject.OwnerOption          | SpecifyGameObject                        |
| indexResult                     | 0                                        |
| isContained                     | False                                    |
| isContainedEvent.Name           | cont                                     |
| isContainedEvent.targetState    | +3                                       |
| isNotContainedEvent.Name        | skip                                     |
| isNotContainedEvent.targetState | VERANDA Check                            |
| reference                       |                                          |
| variable                        | Il2CppHutongGames.PlayMaker.FsmVar       |
| variable.Type                   | GameObject                               |
| variable.variableName           |                                          |

## State 15: +3

| Property       | Value |
| -------------- | ----- |
| ActionCount    | 1     |
| Description    |       |
| HandlesOnEvent | False |
| MaxLoopCount   | 0     |
| Name           | +3    |
| StateIndex     | 15    |

### 15 +3: Transitions

| EventName | ToFsmState    |
| --------- | ------------- |
| FINISHED  | VERANDA Check |

### 15 +3: Actions

#### Action: 15-0 IntAdd

General Action Details:

| Property     | Value                                      |
| ------------ | ------------------------------------------ |
| ActionIndex  | 0                                          |
| BlockFinish  | True                                       |
| Enabled      | True                                       |
| Name         |                                            |
| StateIndex   | 15                                         |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntAdd |
| TypeName     | IntAdd                                     |

IntAdd Details:

| Property    | Value |
| ----------- | ----- |
| add         | 3     |
| everyFrame  | False |
| intVariable | 0     |

## State 16: SET INT LUCK

| Property       | Value        |
| -------------- | ------------ |
| ActionCount    | 1            |
| Description    |              |
| HandlesOnEvent | False        |
| MaxLoopCount   | 0            |
| Name           | SET INT LUCK |
| StateIndex     | 16           |

### 16 SET INT LUCK: Transitions

| EventName | ToFsmState    |
| --------- | ------------- |
| FINISHED  | Rabbit's Foot |

### 16 SET INT LUCK: Actions

#### Action: 16-0 SetIntValue

General Action Details:

| Property     | Value                                           |
| ------------ | ----------------------------------------------- |
| ActionIndex  | 0                                               |
| BlockFinish  | True                                            |
| Enabled      | True                                            |
| Name         |                                                 |
| StateIndex   | 16                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetIntValue |
| TypeName     | SetIntValue                                     |

SetIntValue Details:

| Property    | Value |
| ----------- | ----- |
| everyFrame  | False |
| intValue    | 999   |
| intVariable | 0     |

## State 17: Set Dowsed Luck

| Property       | Value           |
| -------------- | --------------- |
| ActionCount    | 3               |
| Description    |                 |
| HandlesOnEvent | False           |
| MaxLoopCount   | 0               |
| Name           | Set Dowsed Luck |
| StateIndex     | 17              |

### 17 Set Dowsed Luck: Transitions

| EventName | ToFsmState    |
| --------- | ------------- |
| FINISHED  | Rabbit's Foot |

### 17 Set Dowsed Luck: Actions

#### Action: 17-0 SetBoolValue

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 0                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 17                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetBoolValue |
| TypeName     | SetBoolValue                                     |

SetBoolValue Details:

| Property     | Value |
| ------------ | ----- |
| boolValue    | True  |
| boolVariable | False |
| everyFrame   | False |

#### Action: 17-1 IntOperator

General Action Details:

| Property     | Value                                           |
| ------------ | ----------------------------------------------- |
| ActionIndex  | 1                                               |
| BlockFinish  | True                                            |
| Enabled      | True                                            |
| Name         |                                                 |
| StateIndex   | 17                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntOperator |
| TypeName     | IntOperator                                     |

IntOperator Details:

| Property    | Value |
| ----------- | ----- |
| everyFrame  | False |
| integer1    | 999   |
| integer2    | 32    |
| operation   | Add   |
| storeResult | 0     |

#### Action: 17-2 SetIntValue

General Action Details:

| Property     | Value                                           |
| ------------ | ----------------------------------------------- |
| ActionIndex  | 2                                               |
| BlockFinish  | True                                            |
| Enabled      | True                                            |
| Name         |                                                 |
| StateIndex   | 17                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetIntValue |
| TypeName     | SetIntValue                                     |

SetIntValue Details:

| Property    | Value |
| ----------- | ----- |
| everyFrame  | False |
| intValue    | 0     |
| intVariable | 0     |

## State 18: Dowse Correction

| Property       | Value            |
| -------------- | ---------------- |
| ActionCount    | 2                |
| Description    |                  |
| HandlesOnEvent | False            |
| MaxLoopCount   | 0                |
| Name           | Dowse Correction |
| StateIndex     | 18               |

### 18 Dowse Correction: Transitions

| EventName | ToFsmState       |
| --------- | ---------------- |
| FINISHED  | Send Drop Target |
| skip      | Send Drop Target |

### 18 Dowse Correction: Actions

#### Action: 18-0 BoolTest

General Action Details:

| Property     | Value                                        |
| ------------ | -------------------------------------------- |
| ActionIndex  | 0                                            |
| BlockFinish  | True                                         |
| Enabled      | True                                         |
| Name         |                                              |
| StateIndex   | 18                                           |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.BoolTest |
| TypeName     | BoolTest                                     |

BoolTest Details:

| Property            | Value            |
| ------------------- | ---------------- |
| boolVariable        | False            |
| everyFrame          | False            |
| isFalse.Name        | skip             |
| isFalse.targetState | Send Drop Target |
| isTrue              | null             |

#### Action: 18-1 SetIntValue

General Action Details:

| Property     | Value                                           |
| ------------ | ----------------------------------------------- |
| ActionIndex  | 1                                               |
| BlockFinish  | True                                            |
| Enabled      | True                                            |
| Name         |                                                 |
| StateIndex   | 18                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetIntValue |
| TypeName     | SetIntValue                                     |

SetIntValue Details:

| Property    | Value |
| ----------- | ----- |
| everyFrame  | False |
| intValue    | 1     |
| intVariable | 2     |

## State 19: Luck Balance Modifiers

| Property       | Value                  |
| -------------- | ---------------------- |
| ActionCount    | 2                      |
| Description    |                        |
| HandlesOnEvent | False                  |
| MaxLoopCount   | 0                      |
| Name           | Luck Balance Modifiers |
| StateIndex     | 19                     |

### 19 Luck Balance Modifiers: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | Luck Check |
| skip      | Dows Check |

### 19 Luck Balance Modifiers: Actions

#### Action: 19-0 BoolTest

General Action Details:

| Property     | Value                                        |
| ------------ | -------------------------------------------- |
| ActionIndex  | 0                                            |
| BlockFinish  | True                                         |
| Enabled      | True                                         |
| Name         |                                              |
| StateIndex   | 19                                           |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.BoolTest |
| TypeName     | BoolTest                                     |

BoolTest Details:

| Property           | Value      |
| ------------------ | ---------- |
| boolVariable       | False      |
| everyFrame         | False      |
| isFalse            | null       |
| isTrue.Name        | skip       |
| isTrue.targetState | Dows Check |

#### Action: 19-1 IntAdd

General Action Details:

| Property     | Value                                      |
| ------------ | ------------------------------------------ |
| ActionIndex  | 1                                          |
| BlockFinish  | True                                       |
| Enabled      | True                                       |
| Name         |                                            |
| StateIndex   | 19                                         |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntAdd |
| TypeName     | IntAdd                                     |

IntAdd Details:

| Property    | Value |
| ----------- | ----- |
| add         | 0     |
| everyFrame  | False |
| intVariable | 0     |

## State 20: Dowsing Check

| Property       | Value         |
| -------------- | ------------- |
| ActionCount    | 1             |
| Description    |               |
| HandlesOnEvent | False         |
| MaxLoopCount   | 0             |
| Name           | Dowsing Check |
| StateIndex     | 20            |

### 20 Dowsing Check: Transitions

| EventName | ToFsmState      |
| --------- | --------------- |
| DOWSED    | Set Dowsed Luck |
| FINISHED  | SET INT LUCK    |

### 20 Dowsing Check: Actions

#### Action: 20-0 BoolTest

General Action Details:

| Property     | Value                                        |
| ------------ | -------------------------------------------- |
| ActionIndex  | 0                                            |
| BlockFinish  | True                                         |
| Enabled      | True                                         |
| Name         |                                              |
| StateIndex   | 20                                           |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.BoolTest |
| TypeName     | BoolTest                                     |

BoolTest Details:

| Property            | Value           |
| ------------------- | --------------- |
| boolVariable        | False           |
| everyFrame          | False           |
| isFalse.Name        | FINISHED        |
| isFalse.targetState | SET INT LUCK    |
| isTrue.Name         | DOWSED          |
| isTrue.targetState  | Set Dowsed Luck |

## State 21: Dowsing Rod

| Property       | Value       |
| -------------- | ----------- |
| ActionCount    | 3           |
| Description    |             |
| HandlesOnEvent | False       |
| MaxLoopCount   | 0           |
| Name           | Dowsing Rod |
| StateIndex     | 21          |

### 21 Dowsing Rod: Transitions

| EventName       | ToFsmState         |
| --------------- | ------------------ |
| Avg Luck        | 1 Item Guarenteed! |
| Extremely Lucky | Dows +2            |
| skip            | Luck Check         |
| Very Lucky      | Dows +1            |

### 21 Dowsing Rod: Actions

#### Action: 21-0 IntCompare

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 0                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 21                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntCompare |
| TypeName     | IntCompare                                     |

IntCompare Details:

| Property             | Value      |
| -------------------- | ---------- |
| equal                | null       |
| everyFrame           | False      |
| greaterThan          | null       |
| integer1             | 0          |
| integer2             | 19         |
| lessThan.Name        | skip       |
| lessThan.targetState | Luck Check |

#### Action: 21-1 SetIntValue

General Action Details:

| Property     | Value                                           |
| ------------ | ----------------------------------------------- |
| ActionIndex  | 1                                               |
| BlockFinish  | True                                            |
| Enabled      | True                                            |
| Name         |                                                 |
| StateIndex   | 21                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetIntValue |
| TypeName     | SetIntValue                                     |

SetIntValue Details:

| Property    | Value |
| ----------- | ----- |
| everyFrame  | False |
| intValue    | 1     |
| intVariable | 2     |

#### Action: 21-2 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 2                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 21                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                         |
| --------------------- | --------------------------------------------- |
| delay                 | 0                                             |
| delayedEvent          | null                                          |
| events.Count          | 3                                             |
| events[0].Name        | Avg Luck                                      |
| events[0].targetState | 1 Item Guarenteed!                            |
| events[1].Name        | Very Lucky                                    |
| events[1].targetState | Dows +1                                       |
| events[2].Name        | Extremely Lucky                               |
| events[2].targetState | Dows +2                                       |
| weight: 0.05          | Event: 'Extremely Lucky' State: 'Dows +2'     |
| weight: 0.1           | Event: 'Very Lucky' State: 'Dows +1'          |
| weight: 0.85          | Event: 'Avg Luck' State: '1 Item Guarenteed!' |
| weights.Count         | 3                                             |
| weights[0]            | 0.85                                          |
| weights[1]            | 0.1                                           |
| weights[2]            | 0.05                                          |

## State 22: Check Dowsing Array

| Property       | Value               |
| -------------- | ------------------- |
| ActionCount    | 2                   |
| Description    |                     |
| HandlesOnEvent | False               |
| MaxLoopCount   | 0                   |
| Name           | Check Dowsing Array |
| StateIndex     | 22                  |

### 22 Check Dowsing Array: Transitions

| EventName | ToFsmState          |
| --------- | ------------------- |
| 1         | Dowsing Rod         |
| 2         | 2 Items Guarenteed! |

### 22 Check Dowsing Array: Actions

#### Action: 22-0 GetFsmGameObject

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 22                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.GetFsmGameObject |
| TypeName     | GetFsmGameObject                                     |

GetFsmGameObject Details:

| Property               | Value                               |
| ---------------------- | ----------------------------------- |
| everyFrame             | False                               |
| fsm                    | null                                |
| fsmName                | FSM                                 |
| fsmNameLastFrame       | null                                |
| gameObject.GameObject  | /__SYSTEM/THE DRAFT/PLAN MANAGEMENT |
| gameObject.OwnerOption | SpecifyGameObject                   |
| goLastFrame            | null                                |
| storeValue             | null                                |
| variableName           | PLAN1 - ENGINE                      |

#### Action: 22-1 ArrayListContains

General Action Details:

| Property     | Value                                                 |
| ------------ | ----------------------------------------------------- |
| ActionIndex  | 1                                                     |
| BlockFinish  | True                                                  |
| Enabled      | True                                                  |
| Name         |                                                       |
| StateIndex   | 22                                                    |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListContains |
| TypeName     | ArrayListContains                                     |

ArrayListContains Details:

| Property                        | Value                                              |
| ------------------------------- | -------------------------------------------------- |
| gameObject.GameObject           | /__SYSTEM/THE DRAFT/PLAN PICKER/DROPTARGET 1 ROOMS |
| gameObject.OwnerOption          | SpecifyGameObject                                  |
| indexResult                     | 0                                                  |
| isContained                     | False                                              |
| isContainedEvent.Name           | 2                                                  |
| isContainedEvent.targetState    | 2 Items Guarenteed!                                |
| isNotContainedEvent.Name        | 1                                                  |
| isNotContainedEvent.targetState | Dowsing Rod                                        |
| reference                       |                                                    |
| variable                        | Il2CppHutongGames.PlayMaker.FsmVar                 |
| variable.Type                   | GameObject                                         |
| variable.variableName           | Current Engine                                     |

## State 23: Dows +1

| Property       | Value   |
| -------------- | ------- |
| ActionCount    | 1       |
| Description    |         |
| HandlesOnEvent | False   |
| MaxLoopCount   | 0       |
| Name           | Dows +1 |
| StateIndex     | 23      |

### 23 Dows +1: Transitions

| EventName | ToFsmState          |
| --------- | ------------------- |
| FINISHED  | 3 Items Guarenteed! |

### 23 Dows +1: Actions

#### Action: 23-0 IntAdd

General Action Details:

| Property     | Value                                      |
| ------------ | ------------------------------------------ |
| ActionIndex  | 0                                          |
| BlockFinish  | True                                       |
| Enabled      | True                                       |
| Name         |                                            |
| StateIndex   | 23                                         |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntAdd |
| TypeName     | IntAdd                                     |

IntAdd Details:

| Property    | Value |
| ----------- | ----- |
| add         | 1     |
| everyFrame  | False |
| intVariable | 0     |

## State 24: Dows +2

| Property       | Value   |
| -------------- | ------- |
| ActionCount    | 1       |
| Description    |         |
| HandlesOnEvent | False   |
| MaxLoopCount   | 0       |
| Name           | Dows +2 |
| StateIndex     | 24      |

### 24 Dows +2: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | 4 out of 4 |

### 24 Dows +2: Actions

#### Action: 24-0 IntAdd

General Action Details:

| Property     | Value                                      |
| ------------ | ------------------------------------------ |
| ActionIndex  | 0                                          |
| BlockFinish  | True                                       |
| Enabled      | True                                       |
| Name         |                                            |
| StateIndex   | 24                                         |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntAdd |
| TypeName     | IntAdd                                     |

IntAdd Details:

| Property    | Value |
| ----------- | ----- |
| add         | 2     |
| everyFrame  | False |
| intVariable | 0     |

## State 25: Dows Check

| Property       | Value      |
| -------------- | ---------- |
| ActionCount    | 2          |
| Description    |            |
| HandlesOnEvent | False      |
| MaxLoopCount   | 0          |
| Name           | Dows Check |
| StateIndex     | 25         |

### 25 Dows Check: Transitions

| EventName | ToFsmState          |
| --------- | ------------------- |
| 0         | State 2             |
| 1         | State 1             |
| FINISHED  | Check Dowsing Array |

### 25 Dows Check: Actions

#### Action: 25-0 IntCompare

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 0                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 25                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntCompare |
| TypeName     | IntCompare                                     |

IntCompare Details:

| Property                | Value   |
| ----------------------- | ------- |
| equal                   | null    |
| everyFrame              | False   |
| greaterThan.Name        | 0       |
| greaterThan.targetState | State 2 |
| integer1                | 0       |
| integer2                | 5       |
| lessThan                | null    |

#### Action: 25-1 IntCompare

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 1                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 25                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntCompare |
| TypeName     | IntCompare                                     |

IntCompare Details:

| Property                | Value   |
| ----------------------- | ------- |
| equal                   | null    |
| everyFrame              | False   |
| greaterThan.Name        | 1       |
| greaterThan.targetState | State 1 |
| integer1                | 0       |
| integer2                | 2       |
| lessThan                | null    |

## State 26: State 1

| Property       | Value   |
| -------------- | ------- |
| ActionCount    | 1       |
| Description    |         |
| HandlesOnEvent | False   |
| MaxLoopCount   | 0       |
| Name           | State 1 |
| StateIndex     | 26      |

### 26 State 1: Transitions

| EventName  | ToFsmState          |
| ---------- | ------------------- |
| Avg Luck   | State 2             |
| Bad Luck   | 1 Item Guarenteed!  |
| Very Lucky | Check Dowsing Array |

### 26 State 1: Actions

#### Action: 26-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 26                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                            |
| --------------------- | ------------------------------------------------ |
| delay                 | 0                                                |
| delayedEvent          | null                                             |
| events.Count          | 3                                                |
| events[0].Name        | Bad Luck                                         |
| events[0].targetState | 1 Item Guarenteed!                               |
| events[1].Name        | Avg Luck                                         |
| events[1].targetState | State 2                                          |
| events[2].Name        | Very Lucky                                       |
| events[2].targetState | Check Dowsing Array                              |
| weight: 0.2           | Event: 'Bad Luck' State: '1 Item Guarenteed!'    |
| weight: 0.2           | Event: 'Very Lucky' State: 'Check Dowsing Array' |
| weight: 0.6           | Event: 'Avg Luck' State: 'State 2'               |
| weights.Count         | 3                                                |
| weights[0]            | 0.2                                              |
| weights[1]            | 0.6                                              |
| weights[2]            | 0.2                                              |

## State 27: State 2

| Property       | Value   |
| -------------- | ------- |
| ActionCount    | 1       |
| Description    |         |
| HandlesOnEvent | False   |
| MaxLoopCount   | 0       |
| Name           | State 2 |
| StateIndex     | 27      |

### 27 State 2: Transitions

| EventName | ToFsmState          |
| --------- | ------------------- |
| Avg Luck  | 2 Items Guarenteed! |
| Bad Luck  | 1 Item Guarenteed!  |

### 27 State 2: Actions

#### Action: 27-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 27                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                          |
| --------------------- | ---------------------------------------------- |
| delay                 | 0                                              |
| delayedEvent          | null                                           |
| events.Count          | 2                                              |
| events[0].Name        | Bad Luck                                       |
| events[0].targetState | 1 Item Guarenteed!                             |
| events[1].Name        | Avg Luck                                       |
| events[1].targetState | 2 Items Guarenteed!                            |
| weight: 0.5           | Event: 'Bad Luck' State: '1 Item Guarenteed!'  |
| weight: 0.5           | Event: 'Avg Luck' State: '2 Items Guarenteed!' |
| weights.Count         | 2                                              |
| weights[0]            | 0.5                                            |
| weights[1]            | 0.5                                            |

