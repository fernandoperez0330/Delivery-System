using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using deliverywindows.entities;
using deliverywindows.utils;

namespace deliverywindows.models
{
    class ModelCustomer: Model
    {
        public EntityCustomer customer;

        public ModelCustomer()
        {
            customer = new EntityCustomer();
        }
        
        
        public override int add()
        {
            try { 
                Cliente dataCliente = new Cliente
                {
                    NOMBRE = customer.Nombre,
                    CIUDAD = customer.IdCiudad,
                    DIRECCION1 = customer.Direccion1,
                    DIRECCION2 = customer.Direccion2,
                    TELEFONO = customer.Telefono
                };
                Data.Clientes.InsertOnSubmit(dataCliente);
                Data.SubmitChanges();
                return 1;
            }catch(Exception exc){
                Utils.logExceptionError(exc);
                return 0;
            }
        }

        public override bool update()
        {
            try {
                var query = from cliente in Data.Clientes
                            where cliente.CODIGO == customer.Codigo
                            select cliente;

                Cliente cli = query.First<Cliente>();
                cli.NOMBRE = customer.Nombre;
                cli.CIUDAD = customer.IdCiudad;
                cli.DIRECCION1 = customer.Direccion1;
                cli.DIRECCION2 = customer.Direccion2;
                cli.TELEFONO = customer.Telefono;

                Data.SubmitChanges();
                return true;
            }catch(Exception exc){
                Utils.logExceptionError(exc);
                return false;
            }
            
        }


        public override bool delete()
        {
            throw new NotImplementedException();
        }

        public IQueryable findByName(String name)
        {
            var queryCustomer = from cliente in Data.Clientes
                                where cliente.NOMBRE.Contains(name)
                                select cliente;
            return queryCustomer;
        }

        public override Entity find(int prkey)
        {

            var queryCustomer = from cliente in Data.Clientes
                                where cliente.CODIGO == prkey
                                select cliente;

            foreach (Cliente cliente in queryCustomer)
            {
                this.customer.Codigo = cliente.CODIGO;
                this.customer.Nombre = cliente.NOMBRE;
                this.customer.Telefono = cliente.TELEFONO;
                this.customer.Direccion1 = cliente.DIRECCION1;
                this.customer.Direccion2 = cliente.DIRECCION2;
                this.customer.IdCiudad = cliente.Ciudade.CODIGO;
                this.customer.NombreCiudad = cliente.Ciudade.DESCRIPCION;
            }

            return customer;
        }

        public IQueryable findAll()
        {
            var queryCustomer = from cliente in Data.Clientes
                                select new { cliente.CODIGO,cliente.NOMBRE, CIUDAD = cliente.Ciudade.DESCRIPCION, cliente.DIRECCION1, cliente.DIRECCION2, cliente.TELEFONO };
            return queryCustomer;
        }


    }
}
