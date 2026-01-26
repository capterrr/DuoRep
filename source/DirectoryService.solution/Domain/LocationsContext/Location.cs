using Domain.LocationsContext.ValueObjects;
<<<<<<< HEAD
<<<<<<< HEAD
using Domain.Position.ValueObjects;
=======
>>>>>>> cf601eb (добавил модели)
=======
using Domain.Position.ValueObjects;
>>>>>>> 3b70da4 (Сделал работу)
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
<<<<<<< HEAD
<<<<<<< HEAD
using static Domain.LocationsContext.ValueObjects.LocationAdderss;

namespace Domain.LocationsContext;
public class Location
{
    public Location (Locationid id, LocationName name, LocationAddress address, EntityLifeTime lifeTime, IanaTimeZone timeZone)
    {
        Id = id;
        Name = name;
        Address = address;
        LifeTime = lifeTime;
        TimeZone = timeZone;
    }
    public Locationid Id { get; }
    public LocationName Name { get; }
    public LocationAddress Address { get; }
    public EntityLifeTime LifeTime { get; }
    public IanaTimeZone TimeZone { get; }
}
=======
=======
using static Domain.LocationsContext.ValueObjects.LocationAdderss;
>>>>>>> 3b70da4 (Сделал работу)

namespace Domain.LocationsContext;
public class Location
{
    public Location (Locationid id, LocationName name, LocationAddress address, EntityLifeTime lifeTime, IanaTimeZone timeZone)
    {
        Id = id;
        Name = name;
        Address = address;
        LifeTime = lifeTime;
        TimeZone = timeZone;
    }
<<<<<<< HEAD
}
>>>>>>> cf601eb (добавил модели)
=======
    public Locationid Id { get; }
    public LocationName Name { get; }
    public LocationAddress Address { get; }
    public EntityLifeTime LifeTime { get; }
    public IanaTimeZone TimeZone { get; }
}
>>>>>>> 3b70da4 (Сделал работу)
