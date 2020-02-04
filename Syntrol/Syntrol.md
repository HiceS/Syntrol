<a name='assembly'></a>
# Syntrol

## Contents

- [Com](#T-Syntrol-Coms-Com 'Syntrol.Coms.Com')
- [ComException](#T-Syntrol-Exceptions-ComException 'Syntrol.Exceptions.ComException')
  - [#ctor()](#M-Syntrol-Exceptions-ComException-#ctor 'Syntrol.Exceptions.ComException.#ctor')
  - [#ctor(message,inner)](#M-Syntrol-Exceptions-ComException-#ctor-System-String,System-Exception- 'Syntrol.Exceptions.ComException.#ctor(System.String,System.Exception)')
- [ComObject](#T-Syntrol-Robot-ComObject 'Syntrol.Robot.ComObject')
- [ComStateEnum](#T-Syntrol-Communication-ComStateEnum 'Syntrol.Communication.ComStateEnum')
  - [Connected](#F-Syntrol-Communication-ComStateEnum-Connected 'Syntrol.Communication.ComStateEnum.Connected')
  - [Disconnected](#F-Syntrol-Communication-ComStateEnum-Disconnected 'Syntrol.Communication.ComStateEnum.Disconnected')
  - [Emergency](#F-Syntrol-Communication-ComStateEnum-Emergency 'Syntrol.Communication.ComStateEnum.Emergency')
  - [Unavailable](#F-Syntrol-Communication-ComStateEnum-Unavailable 'Syntrol.Communication.ComStateEnum.Unavailable')
- [Motor](#T-Syntrol-Robot-Controller-Motor 'Syntrol.Robot.Controller.Motor')
  - [Channel](#P-Syntrol-Robot-Controller-Motor-Channel 'Syntrol.Robot.Controller.Motor.Channel')
  - [GrpcObject](#P-Syntrol-Robot-Controller-Motor-GrpcObject 'Syntrol.Robot.Controller.Motor.GrpcObject')
  - [Torque](#P-Syntrol-Robot-Controller-Motor-Torque 'Syntrol.Robot.Controller.Motor.Torque')
  - [UID](#P-Syntrol-Robot-Controller-Motor-UID 'Syntrol.Robot.Controller.Motor.UID')
- [Robot](#T-Syntrol-Robot-Robot 'Syntrol.Robot.Robot')
  - [#ctor(uuid)](#M-Syntrol-Robot-Robot-#ctor-System-String- 'Syntrol.Robot.Robot.#ctor(System.String)')
- [State](#T-Syntrol-Communication-State 'Syntrol.Communication.State')
- [State](#T-Syntrol-Robot-State 'Syntrol.Robot.State')
  - [ComStatus](#P-Syntrol-Communication-State-ComStatus 'Syntrol.Communication.State.ComStatus')
- [Syntrol](#T-Syntrol-Syntrol 'Syntrol.Syntrol')
- [World](#T-Syntrol-World-World 'Syntrol.World.World')

<a name='T-Syntrol-Coms-Com'></a>
## Com `type`

##### Namespace

Syntrol.Coms

##### Summary

Class to send a recieve data from grpc to product

<a name='T-Syntrol-Exceptions-ComException'></a>
## ComException `type`

##### Namespace

Syntrol.Exceptions

##### Summary

Exception for checking current connection status

<a name='M-Syntrol-Exceptions-ComException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Base exception

##### Parameters

This constructor has no parameters.

<a name='M-Syntrol-Exceptions-ComException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,inner) `constructor`

##### Summary

Com Exception that contains a reference to the frame

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| inner | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |

<a name='T-Syntrol-Robot-ComObject'></a>
## ComObject `type`

##### Namespace

Syntrol.Robot

##### Summary

Abstract base class for reading and writing from Coms

<a name='T-Syntrol-Communication-ComStateEnum'></a>
## ComStateEnum `type`

##### Namespace

Syntrol.Communication

##### Summary

Enum of possible communication states

<a name='F-Syntrol-Communication-ComStateEnum-Connected'></a>
### Connected `constants`

##### Summary

Currently Connected

<a name='F-Syntrol-Communication-ComStateEnum-Disconnected'></a>
### Disconnected `constants`

##### Summary

Not Connected to Simulator

<a name='F-Syntrol-Communication-ComStateEnum-Emergency'></a>
### Emergency `constants`

##### Summary

Emergency Stopped

<a name='F-Syntrol-Communication-ComStateEnum-Unavailable'></a>
### Unavailable `constants`

##### Summary

Cannot make a new Connection

<a name='T-Syntrol-Robot-Controller-Motor'></a>
## Motor `type`

##### Namespace

Syntrol.Robot.Controller

##### Summary

Base Motor Object

##### Remarks

abstractable to create new types of motors with default properties

<a name='P-Syntrol-Robot-Controller-Motor-Channel'></a>
### Channel `property`

##### Summary

Channel motorController is currently reading on

##### Returns



<a name='P-Syntrol-Robot-Controller-Motor-GrpcObject'></a>
### GrpcObject `property`

##### Summary

Temporary for holding the place of the grpc object defining this

##### Returns



<a name='P-Syntrol-Robot-Controller-Motor-Torque'></a>
### Torque `property`

##### Summary

Torque output of motorController

##### Returns



##### Remarks

This should be a curve ideally, not sure how to represent that (maybe a nested function or datatype that understands polynomials)

<a name='P-Syntrol-Robot-Controller-Motor-UID'></a>
### UID `property`

##### Summary

Unique Idnetifier for the motorController

##### Returns



<a name='T-Syntrol-Robot-Robot'></a>
## Robot `type`

##### Namespace

Syntrol.Robot

##### Summary

Base object that contains unique info for simulation

<a name='M-Syntrol-Robot-Robot-#ctor-System-String-'></a>
### #ctor(uuid) `constructor`

##### Summary

New Robot Object creates new comm instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| uuid | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Syntrol-Communication-State'></a>
## State `type`

##### Namespace

Syntrol.Communication

<a name='T-Syntrol-Robot-State'></a>
## State `type`

##### Namespace

Syntrol.Robot

##### Summary

State is the collection of current hardware values for robot

<a name='P-Syntrol-Communication-State-ComStatus'></a>
### ComStatus `property`

##### Summary

Has the connection state for the API

<a name='T-Syntrol-Syntrol'></a>
## Syntrol `type`

##### Namespace

Syntrol

##### Summary

Parent Object

<a name='T-Syntrol-World-World'></a>
## World `type`

##### Namespace

Syntrol.World

##### Summary

World Object for accessing world data

##### Remarks

Like field element positions etc
mostly for machine learning
