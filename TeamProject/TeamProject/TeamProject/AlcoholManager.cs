using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TeamProject
{
    class AlcoholManager
    {
        public List<Alcohol> alcohols;
        public User user;
        public List<Conditions> conditions;

        public List<double?> Volumes(Alcohol alcohol, User user)
        {
            List<double?> concs = new List<double?>();

            foreach (var item in conditions)
            {
                var c = item.Concentration;
                var A = c * user.Weight * user.WidmarK;
                concs.Add(A);
            }

            return concs;
        }


        private const double _B60 = 0.15; //это не изменяющийся параметр, показывающий кол-во промилле выводящееся за час из организма


        public List<double?> TimeToClean(Alcohol alcohol, User user)
        {
            List<double?> hours = new List<double?>();
            List<double?> concs = Volumes(alcohol, user);

            foreach (var item in concs)
            {
                hours.Add(item / _B60);
            }
            
            return hours;
        }


        
    }
            
}
