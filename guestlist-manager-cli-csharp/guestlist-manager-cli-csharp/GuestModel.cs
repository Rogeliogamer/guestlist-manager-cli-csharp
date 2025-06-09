using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson.Serialization.Attributes;
using System;

namespace guestlist_manager_cli_csharp
{
    internal class GuestModel
    {
        [BsonId]  // _id
        public Guid Id { get; set; }
        public string Email { get; set; }

        [BsonElement("Name")]
        public string FullName { get; set; }
        public bool HasConfirmed { get; set; }
    }
}
