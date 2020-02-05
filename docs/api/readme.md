# API

## Namespaces

### Communication `private`

Communication layer with GRPC to the simulator.

Not exposed to the public

### Robot `public`

Robot has state with the following

#### Controllers `public`
Robot may have many motor controllers

#### Sensors `public`
Robot may have many Sensors

### Exceptions `public`

#### ComException
Gets called everytime a write or read is done on a robot object,

Can throw an exception based off communication state.

### World `public`
May throw a ComException

Can access various world elements that have been specifically allowed to transmit.