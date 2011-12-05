using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using deliverywindows.entities;
using System.Collections;

namespace deliverywindows.models
{
    class ModelCountry: Model
    {   

        public override int add()
        {
            throw new NotImplementedException();
        }

        public override bool update()
        {
            throw new NotImplementedException();
        }


        public override bool delete()
        {
            throw new NotImplementedException();
        }

        public override Entity find(int prkey)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// retorna todas las ciudades disponible para un data source
        /// </summary>
        /// <returns></returns>
        public IQueryable getAlltoDataSource() {
            var ciudades = from ciudad in Data.Ciudades
                           select ciudad;
            return ciudades;
        }

        /// <summary>
        /// retorna las ciudades disponible en un sortedlist (par codigo=nombre)
        /// </summary>
        /// <returns></returns>
        public SortedList getAlltoSortedList() {
            SortedList arrCountries = new SortedList();
            //ciudades
            var ciudades = from ciudad in Data.Ciudades
                           select ciudad;

            arrCountries = new SortedList();

            foreach (Ciudade c in ciudades)
            {
                arrCountries.Add(c.CODIGO, c.NOMBRE);
            }
            return arrCountries;
        }

    }
}
