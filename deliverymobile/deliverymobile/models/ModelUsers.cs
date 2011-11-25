using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using deliverymobile.entities;

namespace deliverymobile.models
{
    class ModelUsers:Model
    {
        public override Boolean add(Entity entity)
        {
            return false;
        }
        public override Boolean update(Entity entity)
        {
            return false;
        }
        public override Entity find(Entity entity)
        {
            return null;
        }
        public override Boolean remove(Entity entity) {
            return false;
        }

    }
}
