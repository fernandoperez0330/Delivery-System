using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using deliverymobile.entities;

namespace deliverymobile.models
{
    abstract class Model
    {
        abstract public Boolean add(Entity entity);
        abstract public Boolean update(Entity entity);
        abstract public Entity find(Entity entity);
        abstract public Boolean remove(Entity entity);

    }
}
