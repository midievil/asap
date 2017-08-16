using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Collections
{
    public class OrganizationsCollection
    {
        private Mongo.MongoHelper<Organization> _helper;

        public OrganizationsCollection()
        {
            _helper = new Mongo.MongoHelper<Organization>();
        }

        public void Create(Organization organization)
        {
            _helper.Collection.InsertOne(organization);
        }
    }
}
