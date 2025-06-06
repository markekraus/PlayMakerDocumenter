# /__SYSTEM/LOCKED DOORS ENGINE

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
| Active          | False                                |
| ActiveStateName |                                      |
| Enabled         | False                                |
| FsmDescription  |                                      |
| FsmName         | FSM                                  |
| FullPath        | /__SYSTEM/LOCKED DOORS ENGINE        |
| StateCount      | 36                                   |
| Uuid            | aebe93e0-e3b7-56e8-901d-0193638a72ad |

## Variables

| Name                  | Value | Type          |
| --------------------- | ----- | ------------- |
| active child          | null  | FsmGameObject |
| CURRENT LOCKED ENGINE | null  | FsmGameObject |
| day                   | 0     | FsmInt        |
| lock                  | False | FsmBool       |

## Events

| Name     | Path           |
| -------- | -------------- |
| -1       | null           |
| 0        | null           |
| 1        | null           |
| 2        | null           |
| 3        | null           |
| 4        | null           |
| Begin    | null           |
| FINISHED | System Events/ |

## State 0: State 1

| Property       | Value   |
| -------------- | ------- |
| ActionCount    | 1       |
| Description    |         |
| HandlesOnEvent | False   |
| MaxLoopCount   | 0       |
| Name           | State 1 |
| StateIndex     | 0       |

### 0 State 1: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | Late Days  |

### 0 State 1: Actions

#### Action: 0-0 Wait

General Action Details:

| Property     | Value                                    |
| ------------ | ---------------------------------------- |
| ActionIndex  | 0                                        |
| BlockFinish  | True                                     |
| Enabled      | True                                     |
| Name         |                                          |
| StateIndex   | 0                                        |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.Wait |
| TypeName     | Wait                                     |

Wait Details:

| Property                | Value     |
| ----------------------- | --------- |
| finishEvent.Name        | FINISHED  |
| finishEvent.targetState | Late Days |
| realTime                | False     |
| startTime               | 0         |
| time                    | 10        |
| timer                   | 0         |

## State 1: Set Rank 3 - average

| Property       | Value                |
| -------------- | -------------------- |
| ActionCount    | 10                   |
| Description    |                      |
| HandlesOnEvent | False                |
| MaxLoopCount   | 0                    |
| Name           | Set Rank 3 - average |
| StateIndex     | 1                    |

### 1 Set Rank 3 - average: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 5    |

### 1 Set Rank 3 - average: Actions

#### Action: 1-0 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 0                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 1                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 5 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 1-1 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 1                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 1                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3E |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 1-2 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 2                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 1                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 5 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 1-3 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 3                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 1                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 1-4 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 4                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 1                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 5 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 1-5 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 5                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 1                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 1-6 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 6                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 1                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 5 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 1-7 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 7                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 1                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 1-8 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 8                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 1                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 5 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 1-9 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 9                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 1                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3I |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 2: Early Day

| Property       | Value     |
| -------------- | --------- |
| ActionCount    | 3         |
| Description    |           |
| HandlesOnEvent | False     |
| MaxLoopCount   | 0         |
| Name           | Early Day |
| StateIndex     | 2         |

### 2 Early Day: Transitions

| EventName | ToFsmState           |
| --------- | -------------------- |
| 1         | Set Rank 3 - average |
| 2         | Rank 3 open          |

### 2 Early Day: Actions

#### Action: 2-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 2                                                    |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | 5 BOOLS                       |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 2-1 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 1                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 2                                                    |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | 9 BOOLS                       |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 2-2 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 2                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 2                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                    |
| --------------------- | ---------------------------------------- |
| delay                 | 0                                        |
| delayedEvent          | null                                     |
| events.Count          | 2                                        |
| events[0].Name        | 1                                        |
| events[0].targetState | Set Rank 3 - average                     |
| events[1].Name        | 2                                        |
| events[1].targetState | Rank 3 open                              |
| weight: 0.3           | Event: '2' State: 'Rank 3 open'          |
| weight: 0.7           | Event: '1' State: 'Set Rank 3 - average' |
| weights.Count         | 2                                        |
| weights[0]            | 0.7                                      |
| weights[1]            | 0.3                                      |

## State 3: Set Rank 3 - Early

| Property       | Value              |
| -------------- | ------------------ |
| ActionCount    | 18                 |
| Description    |                    |
| HandlesOnEvent | False              |
| MaxLoopCount   | 0                  |
| Name           | Set Rank 3 - Early |
| StateIndex     | 3                  |

### 3 Set Rank 3 - Early: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 5    |

### 3 Set Rank 3 - Early: Actions

#### Action: 3-0 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 0                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 3                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 3-1 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 1                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 3                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3E |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 3-2 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 2                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 3                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 3-3 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 3                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 3                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 3-4 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 4                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 3                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 3-5 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 5                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 3                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 3-6 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 6                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 3                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 3-7 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 7                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 3                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 3-8 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 8                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 3                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 3-9 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 9                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 3                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3I |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 3-10 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 10                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 3                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 3-11 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 11                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 3                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 3-12 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 12                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 3                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 3-13 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 13                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 3                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 3-14 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 14                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 3                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 7                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 3-15 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 15                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 3                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 3-16 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 16                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 3                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 8                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 3-17 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 17                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 3                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 4: Rank 3 open

| Property       | Value       |
| -------------- | ----------- |
| ActionCount    | 0           |
| Description    |             |
| HandlesOnEvent | False       |
| MaxLoopCount   | 0           |
| Name           | Rank 3 open |
| StateIndex     | 4           |

### 4 Rank 3 open: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 3    |

## State 5: Set Rank 3 - Double

| Property       | Value               |
| -------------- | ------------------- |
| ActionCount    | 20                  |
| Description    |                     |
| HandlesOnEvent | False               |
| MaxLoopCount   | 0                   |
| Name           | Set Rank 3 - Double |
| StateIndex     | 5                   |

### 5 Set Rank 3 - Double: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 4    |

### 5 Set Rank 3 - Double: Actions

#### Action: 5-0 ArrayListSet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 0                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 5                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListSet |
| TypeName     | ArrayListSet                                     |

ArrayListSet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| everyFrame             | False                              |
| forceResizeIdNeeded    | False                              |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| variable               | Il2CppHutongGames.PlayMaker.FsmVar |
| variable.Type          | Bool                               |
| variable.variableName  |                                    |

#### Action: 5-1 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 1                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 5                                                    |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | 9 BOOLS                       |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 5-2 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 2                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 5                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 5-3 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 3                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 5                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3E |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 5-4 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 4                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 5                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 5-5 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 5                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 5                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 5-6 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 6                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 5                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 5-7 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 7                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 5                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 5-8 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 8                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 5                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 5-9 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 9                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 5                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 5-10 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 10                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 5                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 5-11 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 11                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 5                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3I |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 5-12 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 12                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 5                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 5-13 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 13                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 5                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 5-14 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 14                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 5                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 5-15 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 15                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 5                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 5-16 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 16                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 5                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 7                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 5-17 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 17                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 5                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 5-18 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 18                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 5                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 8                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 9 BOOLS                            |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 5-19 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 19                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 5                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 3A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 6: Late Days

| Property       | Value     |
| -------------- | --------- |
| ActionCount    | 5         |
| Description    |           |
| HandlesOnEvent | False     |
| MaxLoopCount   | 0         |
| Name           | Late Days |
| StateIndex     | 6         |

### 6 Late Days: Transitions

| EventName | ToFsmState           |
| --------- | -------------------- |
| -1        | Early Day            |
| 0         | Set Rank 3 - Double  |
| 1         | Set Rank 3 - Early   |
| 2         | Set Rank 3 - average |
| 3         | Rank 3 open          |

### 6 Late Days: Actions

#### Action: 6-0 GetFsmInt

General Action Details:

| Property     | Value                                         |
| ------------ | --------------------------------------------- |
| ActionIndex  | 0                                             |
| BlockFinish  | True                                          |
| Enabled      | True                                          |
| Name         |                                               |
| StateIndex   | 6                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.GetFsmInt |
| TypeName     | GetFsmInt                                     |

GetFsmInt Details:

| Property               | Value             |
| ---------------------- | ----------------- |
| everyFrame             | False             |
| fsm                    | null              |
| fsmName                | FSM               |
| fsmNameLastFrame       | null              |
| gameObject.GameObject  | /DAY              |
| gameObject.OwnerOption | SpecifyGameObject |
| goLastFrame            | null              |
| storeValue             | 0                 |
| variableName           | Day               |

#### Action: 6-1 IntCompare

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 1                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 6                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.IntCompare |
| TypeName     | IntCompare                                     |

IntCompare Details:

| Property             | Value     |
| -------------------- | --------- |
| equal                | null      |
| everyFrame           | False     |
| greaterThan          | null      |
| integer1             | 0         |
| integer2             | 4         |
| lessThan.Name        | -1        |
| lessThan.targetState | Early Day |

#### Action: 6-2 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 2                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 6                                                    |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | 5 BOOLS                       |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 6-3 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 3                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 6                                                    |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | 9 BOOLS                       |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 6-4 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 4                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 6                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                    |
| --------------------- | ---------------------------------------- |
| delay                 | 0                                        |
| delayedEvent          | null                                     |
| events.Count          | 4                                        |
| events[0].Name        | 0                                        |
| events[0].targetState | Set Rank 3 - Double                      |
| events[1].Name        | 1                                        |
| events[1].targetState | Set Rank 3 - Early                       |
| events[2].Name        | 2                                        |
| events[2].targetState | Set Rank 3 - average                     |
| events[3].Name        | 3                                        |
| events[3].targetState | Rank 3 open                              |
| weight: 0.05          | Event: '0' State: 'Set Rank 3 - Double'  |
| weight: 0.1           | Event: '1' State: 'Set Rank 3 - Early'   |
| weight: 0.3           | Event: '3' State: 'Rank 3 open'          |
| weight: 0.55          | Event: '2' State: 'Set Rank 3 - average' |
| weights.Count         | 4                                        |
| weights[0]            | 0.05                                     |
| weights[1]            | 0.1                                      |
| weights[2]            | 0.55                                     |
| weights[3]            | 0.3                                      |

## State 7: Set Rank 4 - One Lock

| Property       | Value                 |
| -------------- | --------------------- |
| ActionCount    | 19                    |
| Description    |                       |
| HandlesOnEvent | False                 |
| MaxLoopCount   | 0                     |
| Name           | Set Rank 4 - One Lock |
| StateIndex     | 7                     |

### 7 Set Rank 4 - One Lock: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 7    |

### 7 Set Rank 4 - One Lock: Actions

#### Action: 7-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 7                                                    |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | 10 BOOLS                      |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 7-1 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 1                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 7                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 7-2 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 7                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 7-3 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 7                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 7-4 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 7                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 7-5 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 5                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 7                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 7-6 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 6                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 7                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 7-7 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 7                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 7                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 7-8 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 8                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 7                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 7-9 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 9                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 7                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 7-10 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 10                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 7                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4E |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 7-11 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 11                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 7                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 7-12 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 12                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 7                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 7-13 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 13                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 7                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 7-14 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 14                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 7                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 7-15 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 15                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 7                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 7                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 7-16 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 16                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 7                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 7-17 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 17                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 7                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 8                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 7-18 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 18                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 7                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4I |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 8: Rank 4 open

| Property       | Value       |
| -------------- | ----------- |
| ActionCount    | 0           |
| Description    |             |
| HandlesOnEvent | False       |
| MaxLoopCount   | 0           |
| Name           | Rank 4 open |
| StateIndex     | 8           |

### 8 Rank 4 open: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 6    |

## State 9: Set Rank 4 - Triple

| Property       | Value               |
| -------------- | ------------------- |
| ActionCount    | 19                  |
| Description    |                     |
| HandlesOnEvent | False               |
| MaxLoopCount   | 0                   |
| Name           | Set Rank 4 - Triple |
| StateIndex     | 9                   |

### 9 Set Rank 4 - Triple: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 8    |

### 9 Set Rank 4 - Triple: Actions

#### Action: 9-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 9                                                    |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | 10 BOOLS                      |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 9-1 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 1                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 9                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 9-2 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 9                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 9-3 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 9                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 9-4 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 9                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 9-5 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 5                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 9                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 9-6 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 6                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 9                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 9-7 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 7                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 9                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 9-8 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 8                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 9                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 9-9 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 9                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 9                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 9-10 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 10                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 9                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4E |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 9-11 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 11                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 9                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 9-12 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 12                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 9                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 9-13 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 13                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 9                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 9-14 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 14                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 9                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 9-15 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 15                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 9                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 7                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 9-16 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 16                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 9                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 9-17 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 17                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 9                                                |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 8                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 9-18 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 18                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 9                                              |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4I |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 10: State 3

| Property       | Value   |
| -------------- | ------- |
| ActionCount    | 1       |
| Description    |         |
| HandlesOnEvent | False   |
| MaxLoopCount   | 0       |
| Name           | State 3 |
| StateIndex     | 10      |

### 10 State 3: Transitions

| EventName | ToFsmState            |
| --------- | --------------------- |
| 1         | Set Rank 4 - Triple   |
| 2         | Set Rank 4 - One Lock |

### 10 State 3: Actions

#### Action: 10-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 10                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                     |
| --------------------- | ----------------------------------------- |
| delay                 | 0                                         |
| delayedEvent          | null                                      |
| events.Count          | 2                                         |
| events[0].Name        | 1                                         |
| events[0].targetState | Set Rank 4 - Triple                       |
| events[1].Name        | 2                                         |
| events[1].targetState | Set Rank 4 - One Lock                     |
| weight: 0.3           | Event: '1' State: 'Set Rank 4 - Triple'   |
| weight: 0.7           | Event: '2' State: 'Set Rank 4 - One Lock' |
| weights.Count         | 2                                         |
| weights[0]            | 0.3                                       |
| weights[1]            | 0.7                                       |

## State 11: State 4

| Property       | Value   |
| -------------- | ------- |
| ActionCount    | 1       |
| Description    |         |
| HandlesOnEvent | False   |
| MaxLoopCount   | 0       |
| Name           | State 4 |
| StateIndex     | 11      |

### 11 State 4: Transitions

| EventName | ToFsmState            |
| --------- | --------------------- |
| 1         | Set Rank 4 - One Lock |
| 2         | Rank 4 open           |

### 11 State 4: Actions

#### Action: 11-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 11                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                     |
| --------------------- | ----------------------------------------- |
| delay                 | 0                                         |
| delayedEvent          | null                                      |
| events.Count          | 2                                         |
| events[0].Name        | 1                                         |
| events[0].targetState | Set Rank 4 - One Lock                     |
| events[1].Name        | 2                                         |
| events[1].targetState | Rank 4 open                               |
| weight: 0.4           | Event: '1' State: 'Set Rank 4 - One Lock' |
| weight: 0.6           | Event: '2' State: 'Rank 4 open'           |
| weights.Count         | 2                                         |
| weights[0]            | 0.4                                       |
| weights[1]            | 0.6                                       |

## State 12: State 5

| Property       | Value   |
| -------------- | ------- |
| ActionCount    | 1       |
| Description    |         |
| HandlesOnEvent | False   |
| MaxLoopCount   | 0       |
| Name           | State 5 |
| StateIndex     | 12      |

### 12 State 5: Transitions

| EventName | ToFsmState            |
| --------- | --------------------- |
| 1         | Set Rank 4 - Triple   |
| 2         | Set Rank 4 - Average  |
| 3         | Set Rank 4 - One Lock |
| 4         | Rank 4 open           |

### 12 State 5: Actions

#### Action: 12-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 12                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                     |
| --------------------- | ----------------------------------------- |
| delay                 | 0                                         |
| delayedEvent          | null                                      |
| events.Count          | 4                                         |
| events[0].Name        | 1                                         |
| events[0].targetState | Set Rank 4 - Triple                       |
| events[1].Name        | 2                                         |
| events[1].targetState | Set Rank 4 - Average                      |
| events[2].Name        | 3                                         |
| events[2].targetState | Set Rank 4 - One Lock                     |
| events[3].Name        | 4                                         |
| events[3].targetState | Rank 4 open                               |
| weight: 0.05          | Event: '4' State: 'Rank 4 open'           |
| weight: 0.15          | Event: '1' State: 'Set Rank 4 - Triple'   |
| weight: 0.3           | Event: '3' State: 'Set Rank 4 - One Lock' |
| weight: 0.4           | Event: '2' State: 'Set Rank 4 - Average'  |
| weights.Count         | 4                                         |
| weights[0]            | 0.15                                      |
| weights[1]            | 0.4                                       |
| weights[2]            | 0.3                                       |
| weights[3]            | 0.05                                      |

## State 13: Set Rank 5 - average

| Property       | Value                |
| -------------- | -------------------- |
| ActionCount    | 15                   |
| Description    |                      |
| HandlesOnEvent | False                |
| MaxLoopCount   | 0                    |
| Name           | Set Rank 5 - average |
| StateIndex     | 13                   |

### 13 Set Rank 5 - average: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 10   |

### 13 Set Rank 5 - average: Actions

#### Action: 13-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 13                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | Rank 5                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 13-1 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 1                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 13                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 13-2 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 13                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 13-3 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 13                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 13-4 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 13                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 13-5 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 5                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 13                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 13-6 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 6                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 13                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 13-7 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 7                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 13                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 13-8 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 8                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 13                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 13-9 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 9                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 13                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 13-10 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 10                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 13                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 13-11 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 11                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 13                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 13-12 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 12                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 13                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 13-13 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 13                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 13                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 13-14 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 14                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 13                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 14: Set Rank 4 - Average

| Property       | Value                |
| -------------- | -------------------- |
| ActionCount    | 19                   |
| Description    |                      |
| HandlesOnEvent | False                |
| MaxLoopCount   | 0                    |
| Name           | Set Rank 4 - Average |
| StateIndex     | 14                   |

### 14 Set Rank 4 - Average: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 7    |

### 14 Set Rank 4 - Average: Actions

#### Action: 14-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 14                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | 10 BOOLS                      |
| shufflingRange         | 11                            |
| startIndex             | 0                             |

#### Action: 14-1 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 1                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 14                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 14-2 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 14                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 14-3 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 14                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 14-4 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 14                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 14-5 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 5                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 14                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 14-6 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 6                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 14                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 14-7 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 7                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 14                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 14-8 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 8                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 14                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 14-9 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 9                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 14                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 14-10 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 10                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 14                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4E |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 14-11 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 11                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 14                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 14-12 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 12                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 14                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 14-13 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 13                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 14                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 14-14 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 14                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 14                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 14-15 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 15                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 14                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 7                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 14-16 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 16                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 14                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 14-17 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 17                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 14                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 8                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | 10 BOOLS                           |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 14-18 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 18                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 14                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 4I |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 15: Set Rank 5 - Kinda Open

| Property       | Value                   |
| -------------- | ----------------------- |
| ActionCount    | 15                      |
| Description    |                         |
| HandlesOnEvent | False                   |
| MaxLoopCount   | 0                       |
| Name           | Set Rank 5 - Kinda Open |
| StateIndex     | 15                      |

### 15 Set Rank 5 - Kinda Open: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 9    |

### 15 Set Rank 5 - Kinda Open: Actions

#### Action: 15-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 15                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | Rank 5                        |
| shufflingRange         | 8                             |
| startIndex             | 0                             |

#### Action: 15-1 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 1                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 15                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 15-2 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 15                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 15-3 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 15                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 15-4 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 15                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 15-5 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 5                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 15                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 15-6 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 6                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 15                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 15-7 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 7                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 15                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 15-8 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 8                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 15                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 15-9 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 9                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 15                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 15-10 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 10                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 15                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 15-11 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 11                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 15                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 15-12 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 12                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 15                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 15-13 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 13                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 15                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 15-14 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 14                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 15                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 16: Set Rank 5 - Heavy Lock

| Property       | Value                   |
| -------------- | ----------------------- |
| ActionCount    | 15                      |
| Description    |                         |
| HandlesOnEvent | False                   |
| MaxLoopCount   | 0                       |
| Name           | Set Rank 5 - Heavy Lock |
| StateIndex     | 16                      |

### 16 Set Rank 5 - Heavy Lock: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 11   |

### 16 Set Rank 5 - Heavy Lock: Actions

#### Action: 16-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 16                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | Rank 5                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 16-1 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 1                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 16                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 16-2 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 16                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 16-3 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 16                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 16-4 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 16                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 16-5 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 5                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 16                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 16-6 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 6                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 16                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 16-7 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 7                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 16                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 16-8 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 8                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 16                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 16-9 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 9                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 16                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 16-10 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 10                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 16                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 16-11 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 11                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 16                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 16-12 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 12                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 16                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 16-13 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 13                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 16                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 5                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 16-14 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 14                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 16                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 17: State 6

| Property       | Value   |
| -------------- | ------- |
| ActionCount    | 1       |
| Description    |         |
| HandlesOnEvent | False   |
| MaxLoopCount   | 0       |
| Name           | State 6 |
| StateIndex     | 17      |

### 17 State 6: Transitions

| EventName | ToFsmState              |
| --------- | ----------------------- |
| 1         | Set Rank 5 - Heavy Lock |
| 2         | Set Rank 5 - average    |

### 17 State 6: Actions

#### Action: 17-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 17                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                       |
| --------------------- | ------------------------------------------- |
| delay                 | 0                                           |
| delayedEvent          | null                                        |
| events.Count          | 2                                           |
| events[0].Name        | 1                                           |
| events[0].targetState | Set Rank 5 - Heavy Lock                     |
| events[1].Name        | 2                                           |
| events[1].targetState | Set Rank 5 - average                        |
| weight: 0.5           | Event: '1' State: 'Set Rank 5 - Heavy Lock' |
| weight: 0.5           | Event: '2' State: 'Set Rank 5 - average'    |
| weights.Count         | 2                                           |
| weights[0]            | 0.5                                         |
| weights[1]            | 0.5                                         |

## State 18: State 7

| Property       | Value   |
| -------------- | ------- |
| ActionCount    | 1       |
| Description    |         |
| HandlesOnEvent | False   |
| MaxLoopCount   | 0       |
| Name           | State 7 |
| StateIndex     | 18      |

### 18 State 7: Transitions

| EventName | ToFsmState              |
| --------- | ----------------------- |
| 1         | Set Rank 5 - Heavy Lock |
| 2         | Set Rank 5 - average    |
| 3         | Set Rank 5 - Kinda Open |

### 18 State 7: Actions

#### Action: 18-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 18                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                       |
| --------------------- | ------------------------------------------- |
| delay                 | 0                                           |
| delayedEvent          | null                                        |
| events.Count          | 3                                           |
| events[0].Name        | 1                                           |
| events[0].targetState | Set Rank 5 - Heavy Lock                     |
| events[1].Name        | 2                                           |
| events[1].targetState | Set Rank 5 - average                        |
| events[2].Name        | 3                                           |
| events[2].targetState | Set Rank 5 - Kinda Open                     |
| weight: 0.1           | Event: '1' State: 'Set Rank 5 - Heavy Lock' |
| weight: 0.3           | Event: '3' State: 'Set Rank 5 - Kinda Open' |
| weight: 0.6           | Event: '2' State: 'Set Rank 5 - average'    |
| weights.Count         | 3                                           |
| weights[0]            | 0.1                                         |
| weights[1]            | 0.6                                         |
| weights[2]            | 0.3                                         |

## State 19: State 8

| Property       | Value   |
| -------------- | ------- |
| ActionCount    | 1       |
| Description    |         |
| HandlesOnEvent | False   |
| MaxLoopCount   | 0       |
| Name           | State 8 |
| StateIndex     | 19      |

### 19 State 8: Transitions

| EventName | ToFsmState              |
| --------- | ----------------------- |
| 1         | Set Rank 5 - average    |
| 2         | Set Rank 5 - Kinda Open |

### 19 State 8: Actions

#### Action: 19-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 19                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                       |
| --------------------- | ------------------------------------------- |
| delay                 | 0                                           |
| delayedEvent          | null                                        |
| events.Count          | 2                                           |
| events[0].Name        | 1                                           |
| events[0].targetState | Set Rank 5 - average                        |
| events[1].Name        | 2                                           |
| events[1].targetState | Set Rank 5 - Kinda Open                     |
| weight: 0.5           | Event: '1' State: 'Set Rank 5 - average'    |
| weight: 0.5           | Event: '2' State: 'Set Rank 5 - Kinda Open' |
| weights.Count         | 2                                           |
| weights[0]            | 0.5                                         |
| weights[1]            | 0.5                                         |

## State 20: Set Rank 6 - Average 2

| Property       | Value                  |
| -------------- | ---------------------- |
| ActionCount    | 19                     |
| Description    |                        |
| HandlesOnEvent | False                  |
| MaxLoopCount   | 0                      |
| Name           | Set Rank 6 - Average 2 |
| StateIndex     | 20                     |

### 20 Set Rank 6 - Average 2: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 12   |

### 20 Set Rank 6 - Average 2: Actions

#### Action: 20-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 20                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | Rank 6                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 20-1 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 1                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 20                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 20-2 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 20                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5E |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 20-3 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 20                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 20-4 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 20                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5I |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 20-5 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 5                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 20                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 20-6 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 6                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 20                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 20-7 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 7                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 20                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 20-8 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 8                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 20                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 20-9 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 9                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 20                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 20-10 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 10                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 20                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 20-11 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 11                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 20                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 20-12 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 12                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 20                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 20-13 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 13                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 20                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 20-14 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 14                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 20                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 20-15 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 15                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 20                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 7                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 20-16 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 16                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 20                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 20-17 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 17                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 20                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 8                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 20-18 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 18                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 20                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 21: Set Rank 6 - Locked

| Property       | Value               |
| -------------- | ------------------- |
| ActionCount    | 19                  |
| Description    |                     |
| HandlesOnEvent | False               |
| MaxLoopCount   | 0                   |
| Name           | Set Rank 6 - Locked |
| StateIndex     | 21                  |

### 21 Set Rank 6 - Locked: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 12   |

### 21 Set Rank 6 - Locked: Actions

#### Action: 21-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 21                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | Rank 6                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 21-1 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 1                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 21                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 21-2 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 21                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5E |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 21-3 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 21                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 21-4 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 21                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5I |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 21-5 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 5                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 21                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 21-6 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 6                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 21                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 21-7 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 7                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 21                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 21-8 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 8                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 21                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 21-9 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 9                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 21                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 21-10 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 10                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 21                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 21-11 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 11                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 21                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 21-12 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 12                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 21                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 21-13 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 13                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 21                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 21-14 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 14                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 21                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 21-15 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 15                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 21                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 7                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 21-16 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 16                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 21                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 21-17 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 17                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 21                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 8                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 21-18 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 18                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 21                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 22: Set Rank 6 - Open

| Property       | Value             |
| -------------- | ----------------- |
| ActionCount    | 19                |
| Description    |                   |
| HandlesOnEvent | False             |
| MaxLoopCount   | 0                 |
| Name           | Set Rank 6 - Open |
| StateIndex     | 22                |

### 22 Set Rank 6 - Open: Transitions

| EventName | ToFsmState           |
| --------- | -------------------- |
| FINISHED  | Set Rank 7 - Average |

### 22 Set Rank 6 - Open: Actions

#### Action: 22-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 22                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | Rank 6                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 22-1 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 1                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 22                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 22-2 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 22                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5E |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 22-3 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 22                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 22-4 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 22                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 5I |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 22-5 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 5                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 22                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 22-6 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 6                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 22                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 22-7 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 7                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 22                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 22-8 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 8                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 22                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 22-9 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 9                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 22                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 22-10 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 10                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 22                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 22-11 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 11                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 22                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 22-12 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 12                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 22                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 22-13 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 13                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 22                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 22-14 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 14                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 22                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 22-15 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 15                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 22                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 7                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 22-16 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 16                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 22                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 22-17 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 17                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 22                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 8                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 6                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 22-18 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 18                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 22                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 23: State 9

| Property       | Value   |
| -------------- | ------- |
| ActionCount    | 1       |
| Description    |         |
| HandlesOnEvent | False   |
| MaxLoopCount   | 0       |
| Name           | State 9 |
| StateIndex     | 23      |

### 23 State 9: Transitions

| EventName | ToFsmState             |
| --------- | ---------------------- |
| 1         | Set Rank 6 - Locked    |
| 2         | Set Rank 6 - Average 2 |

### 23 State 9: Actions

#### Action: 23-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 23                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                      |
| --------------------- | ------------------------------------------ |
| delay                 | 0                                          |
| delayedEvent          | null                                       |
| events.Count          | 2                                          |
| events[0].Name        | 1                                          |
| events[0].targetState | Set Rank 6 - Locked                        |
| events[1].Name        | 2                                          |
| events[1].targetState | Set Rank 6 - Average 2                     |
| weight: 0.2           | Event: '1' State: 'Set Rank 6 - Locked'    |
| weight: 0.8           | Event: '2' State: 'Set Rank 6 - Average 2' |
| weights.Count         | 2                                          |
| weights[0]            | 0.2                                        |
| weights[1]            | 0.8                                        |

## State 24: State 10

| Property       | Value    |
| -------------- | -------- |
| ActionCount    | 1        |
| Description    |          |
| HandlesOnEvent | False    |
| MaxLoopCount   | 0        |
| Name           | State 10 |
| StateIndex     | 24       |

### 24 State 10: Transitions

| EventName | ToFsmState             |
| --------- | ---------------------- |
| 1         | Set Rank 6 - Locked    |
| 2         | Set Rank 6 - Average 2 |
| 3         | Set Rank 6 - Open      |

### 24 State 10: Actions

#### Action: 24-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 24                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                      |
| --------------------- | ------------------------------------------ |
| delay                 | 0                                          |
| delayedEvent          | null                                       |
| events.Count          | 3                                          |
| events[0].Name        | 1                                          |
| events[0].targetState | Set Rank 6 - Locked                        |
| events[1].Name        | 2                                          |
| events[1].targetState | Set Rank 6 - Average 2                     |
| events[2].Name        | 3                                          |
| events[2].targetState | Set Rank 6 - Open                          |
| weight: 0.1           | Event: '1' State: 'Set Rank 6 - Locked'    |
| weight: 0.1           | Event: '3' State: 'Set Rank 6 - Open'      |
| weight: 0.8           | Event: '2' State: 'Set Rank 6 - Average 2' |
| weights.Count         | 3                                          |
| weights[0]            | 0.1                                        |
| weights[1]            | 0.8                                        |
| weights[2]            | 0.1                                        |

## State 25: State 11

| Property       | Value    |
| -------------- | -------- |
| ActionCount    | 1        |
| Description    |          |
| HandlesOnEvent | False    |
| MaxLoopCount   | 0        |
| Name           | State 11 |
| StateIndex     | 25       |

### 25 State 11: Transitions

| EventName | ToFsmState             |
| --------- | ---------------------- |
| 1         | Set Rank 6 - Average 2 |
| 2         | Set Rank 6 - Open      |

### 25 State 11: Actions

#### Action: 25-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 25                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                      |
| --------------------- | ------------------------------------------ |
| delay                 | 0                                          |
| delayedEvent          | null                                       |
| events.Count          | 2                                          |
| events[0].Name        | 1                                          |
| events[0].targetState | Set Rank 6 - Average 2                     |
| events[1].Name        | 2                                          |
| events[1].targetState | Set Rank 6 - Open                          |
| weight: 0.5           | Event: '1' State: 'Set Rank 6 - Average 2' |
| weight: 0.5           | Event: '2' State: 'Set Rank 6 - Open'      |
| weights.Count         | 2                                          |
| weights[0]            | 0.5                                        |
| weights[1]            | 0.5                                        |

## State 26: Set Rank 7 - Average

| Property       | Value                |
| -------------- | -------------------- |
| ActionCount    | 19                   |
| Description    |                      |
| HandlesOnEvent | False                |
| MaxLoopCount   | 0                    |
| Name           | Set Rank 7 - Average |
| StateIndex     | 26                   |

### 26 Set Rank 7 - Average: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 13   |

### 26 Set Rank 7 - Average: Actions

#### Action: 26-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 26                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | Rank 7                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 26-1 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 1                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 26                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 26-2 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 26                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6E |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 26-3 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 26                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 26-4 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 26                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6I |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 26-5 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 5                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 26                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 26-6 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 6                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 26                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 26-7 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 7                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 26                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 26-8 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 8                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 26                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 26-9 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 9                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 26                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 26-10 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 10                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 26                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 26-11 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 11                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 26                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 26-12 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 12                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 26                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 26-13 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 13                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 26                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 26-14 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 14                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 26                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 26-15 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 15                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 26                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 7                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 26-16 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 16                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 26                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 26-17 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 17                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 26                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 8                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 26-18 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 18                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 26                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 27: Set Rank 7 - Open

| Property       | Value             |
| -------------- | ----------------- |
| ActionCount    | 19                |
| Description    |                   |
| HandlesOnEvent | False             |
| MaxLoopCount   | 0                 |
| Name           | Set Rank 7 - Open |
| StateIndex     | 27                |

### 27 Set Rank 7 - Open: Transitions

| EventName | ToFsmState              |
| --------- | ----------------------- |
| FINISHED  | Set Rank 8 - One Unlock |

### 27 Set Rank 7 - Open: Actions

#### Action: 27-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 27                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | Rank 7                        |
| shufflingRange         | 12                            |
| startIndex             | 0                             |

#### Action: 27-1 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 1                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 27                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 27-2 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 27                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6E |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 27-3 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 27                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 27-4 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 27                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 6I |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 27-5 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 5                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 27                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 27-6 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 6                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 27                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 27-7 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 7                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 27                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 27-8 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 8                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 27                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 27-9 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 9                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 27                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 27-10 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 10                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 27                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 27-11 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 11                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 27                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 27-12 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 12                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 27                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 27-13 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 13                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 27                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 27-14 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 14                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 27                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 27-15 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 15                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 27                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 7                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 27-16 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 16                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 27                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 27-17 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 17                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 27                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 8                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 7                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 27-18 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 18                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 27                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 28: State 12

| Property       | Value    |
| -------------- | -------- |
| ActionCount    | 1        |
| Description    |          |
| HandlesOnEvent | False    |
| MaxLoopCount   | 0        |
| Name           | State 12 |
| StateIndex     | 28       |

### 28 State 12: Transitions

| EventName | ToFsmState           |
| --------- | -------------------- |
| 1         | Set Rank 7 - Average |
| 2         | Set Rank 7 - Open    |

### 28 State 12: Actions

#### Action: 28-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 28                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                    |
| --------------------- | ---------------------------------------- |
| delay                 | 0                                        |
| delayedEvent          | null                                     |
| events.Count          | 2                                        |
| events[0].Name        | 1                                        |
| events[0].targetState | Set Rank 7 - Average                     |
| events[1].Name        | 2                                        |
| events[1].targetState | Set Rank 7 - Open                        |
| weight: 0.5           | Event: '1' State: 'Set Rank 7 - Average' |
| weight: 0.5           | Event: '2' State: 'Set Rank 7 - Open'    |
| weights.Count         | 2                                        |
| weights[0]            | 0.5                                      |
| weights[1]            | 0.5                                      |

## State 29: Set Rank 8 - One Unlock

| Property       | Value                   |
| -------------- | ----------------------- |
| ActionCount    | 19                      |
| Description    |                         |
| HandlesOnEvent | False                   |
| MaxLoopCount   | 0                       |
| Name           | Set Rank 8 - One Unlock |
| StateIndex     | 29                      |

### 29 Set Rank 8 - One Unlock: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 14   |

### 29 Set Rank 8 - One Unlock: Actions

#### Action: 29-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 29                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | Rank 8                        |
| shufflingRange         | 9                             |
| startIndex             | 0                             |

#### Action: 29-1 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 1                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 29                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 29-2 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 29                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7E |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 29-3 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 29                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 29-4 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 29                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7I |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 29-5 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 5                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 29                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 29-6 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 6                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 29                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 29-7 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 7                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 29                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 29-8 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 8                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 29                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 29-9 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 9                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 29                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 29-10 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 10                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 29                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 29-11 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 11                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 29                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 29-12 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 12                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 29                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 29-13 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 13                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 29                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 29-14 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 14                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 29                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 29-15 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 15                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 29                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 7                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 29-16 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 16                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 29                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 29-17 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 17                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 29                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 8                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 29-18 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 18                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 29                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 30: Set Rank 8 - Two Unlocks

| Property       | Value                    |
| -------------- | ------------------------ |
| ActionCount    | 19                       |
| Description    |                          |
| HandlesOnEvent | False                    |
| MaxLoopCount   | 0                        |
| Name           | Set Rank 8 - Two Unlocks |
| StateIndex     | 30                       |

### 30 Set Rank 8 - Two Unlocks: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | State 14   |

### 30 Set Rank 8 - Two Unlocks: Actions

#### Action: 30-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 30                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | Rank 8                        |
| shufflingRange         | 10                            |
| startIndex             | 0                             |

#### Action: 30-1 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 1                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 30                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 30-2 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 30                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7E |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 30-3 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 30                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 30-4 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 30                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 7I |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 30-5 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 5                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 30                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 30-6 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 6                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 30                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 30-7 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 7                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 30                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 30-8 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 8                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 30                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 30-9 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 9                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 30                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 30-10 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 10                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 30                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 30-11 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 11                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 30                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 30-12 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 12                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 30                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 30-13 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 13                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 30                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 6                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 30-14 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 14                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 30                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8F |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 30-15 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 15                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 30                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 7                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 30-16 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 16                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 30                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8G |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 30-17 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 17                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 30                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 8                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 8                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 30-18 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 18                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 30                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8H |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 31: State 13

| Property       | Value    |
| -------------- | -------- |
| ActionCount    | 1        |
| Description    |          |
| HandlesOnEvent | False    |
| MaxLoopCount   | 0        |
| Name           | State 13 |
| StateIndex     | 31       |

### 31 State 13: Transitions

| EventName | ToFsmState               |
| --------- | ------------------------ |
| 1         | Set Rank 8 - One Unlock  |
| 2         | Set Rank 8 - Two Unlocks |

### 31 State 13: Actions

#### Action: 31-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 31                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                        |
| --------------------- | -------------------------------------------- |
| delay                 | 0                                            |
| delayedEvent          | null                                         |
| events.Count          | 2                                            |
| events[0].Name        | 1                                            |
| events[0].targetState | Set Rank 8 - One Unlock                      |
| events[1].Name        | 2                                            |
| events[1].targetState | Set Rank 8 - Two Unlocks                     |
| weight: 0.4           | Event: '2' State: 'Set Rank 8 - Two Unlocks' |
| weight: 0.6           | Event: '1' State: 'Set Rank 8 - One Unlock'  |
| weights.Count         | 2                                            |
| weights[0]            | 0.6                                          |
| weights[1]            | 0.4                                          |

## State 32: State 14

| Property       | Value    |
| -------------- | -------- |
| ActionCount    | 1        |
| Description    |          |
| HandlesOnEvent | False    |
| MaxLoopCount   | 0        |
| Name           | State 14 |
| StateIndex     | 32       |

### 32 State 14: Transitions

| EventName | ToFsmState              |
| --------- | ----------------------- |
| 1         | All Locked              |
| 2         | Set Rank 9 - One Unlock |

### 32 State 14: Actions

#### Action: 32-0 SendRandomEvent

General Action Details:

| Property     | Value                                               |
| ------------ | --------------------------------------------------- |
| ActionIndex  | 0                                                   |
| BlockFinish  | True                                                |
| Enabled      | True                                                |
| Name         |                                                     |
| StateIndex   | 32                                                  |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent |
| TypeName     | SendRandomEvent                                     |

SendRandomEvent Details:

| Property              | Value                                       |
| --------------------- | ------------------------------------------- |
| delay                 | 0                                           |
| delayedEvent          | null                                        |
| events.Count          | 2                                           |
| events[0].Name        | 1                                           |
| events[0].targetState | All Locked                                  |
| events[1].Name        | 2                                           |
| events[1].targetState | Set Rank 9 - One Unlock                     |
| weight: 0.03          | Event: '2' State: 'Set Rank 9 - One Unlock' |
| weight: 0.97          | Event: '1' State: 'All Locked'              |
| weights.Count         | 2                                           |
| weights[0]            | 0.97                                        |
| weights[1]            | 0.03                                        |

## State 33: Set Rank 9 - One Unlock

| Property       | Value                   |
| -------------- | ----------------------- |
| ActionCount    | 13                      |
| Description    |                         |
| HandlesOnEvent | False                   |
| MaxLoopCount   | 0                       |
| Name           | Set Rank 9 - One Unlock |
| StateIndex     | 33                      |

### 33 Set Rank 9 - One Unlock: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | Done       |

### 33 Set Rank 9 - One Unlock: Actions

#### Action: 33-0 ArrayListShuffle

General Action Details:

| Property     | Value                                                |
| ------------ | ---------------------------------------------------- |
| ActionIndex  | 0                                                    |
| BlockFinish  | True                                                 |
| Enabled      | True                                                 |
| Name         |                                                      |
| StateIndex   | 33                                                   |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle |
| TypeName     | ArrayListShuffle                                     |

ArrayListShuffle Details:

| Property               | Value                         |
| ---------------------- | ----------------------------- |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE |
| gameObject.OwnerOption | UseOwner                      |
| reference              | Rank 9                        |
| shufflingRange         | 0                             |
| startIndex             | 0                             |

#### Action: 33-1 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 1                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 33                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 0                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 9                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 33-2 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 2                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 33                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 9A |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 33-3 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 3                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 33                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 1                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 9                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 33-4 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 4                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 33                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 9B |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 33-5 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 5                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 33                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 2                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 9                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 33-6 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 6                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 33                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 9C |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 33-7 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 7                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 33                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 3                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 9                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 33-8 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 8                                              |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 33                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 9D |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 33-9 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 9                                                |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 33                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 4                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 9                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 33-10 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 10                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 33                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8E |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

#### Action: 33-11 ArrayListGet

General Action Details:

| Property     | Value                                            |
| ------------ | ------------------------------------------------ |
| ActionIndex  | 11                                               |
| BlockFinish  | True                                             |
| Enabled      | True                                             |
| Name         |                                                  |
| StateIndex   | 33                                               |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.ArrayListGet |
| TypeName     | ArrayListGet                                     |

ArrayListGet Details:

| Property               | Value                              |
| ---------------------- | ---------------------------------- |
| atIndex                | 5                                  |
| failureEvent           | null                               |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE      |
| gameObject.OwnerOption | UseOwner                           |
| reference              | Rank 9                             |
| result                 | Il2CppHutongGames.PlayMaker.FsmVar |
| result.Type            | Bool                               |
| result.variableName    | lock                               |

#### Action: 33-12 SetFsmBool

General Action Details:

| Property     | Value                                          |
| ------------ | ---------------------------------------------- |
| ActionIndex  | 12                                             |
| BlockFinish  | True                                           |
| Enabled      | True                                           |
| Name         |                                                |
| StateIndex   | 33                                             |
| TypeFullName | Il2CppHutongGames.PlayMaker.Actions.SetFsmBool |
| TypeName     | SetFsmBool                                     |

SetFsmBool Details:

| Property               | Value                                 |
| ---------------------- | ------------------------------------- |
| everyFrame             | False                                 |
| fsm                    | null                                  |
| fsmName                | FSM                                   |
| fsmNameLastFrame       | null                                  |
| gameObject.GameObject  | /__SYSTEM/LOCKED DOORS ENGINE/DOOR 8I |
| gameObject.OwnerOption | SpecifyGameObject                     |
| goLastFrame            | null                                  |
| setValue               | False                                 |
| variableName           | LOCKED OR NOT                         |

## State 34: All Locked

| Property       | Value      |
| -------------- | ---------- |
| ActionCount    | 0          |
| Description    |            |
| HandlesOnEvent | False      |
| MaxLoopCount   | 0          |
| Name           | All Locked |
| StateIndex     | 34         |

### 34 All Locked: Transitions

| EventName | ToFsmState |
| --------- | ---------- |
| FINISHED  | Done       |

## State 35: Done

| Property       | Value |
| -------------- | ----- |
| ActionCount    | 0     |
| Description    |       |
| HandlesOnEvent | False |
| MaxLoopCount   | 0     |
| Name           | Done  |
| StateIndex     | 35    |

