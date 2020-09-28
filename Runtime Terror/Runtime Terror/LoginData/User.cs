using Runtime_Terror.loginData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Runtime_Terror.user
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Number { get; set; }
        public virtual ICollection<LoginData> LoginDatas { get; set; }
        public int FoodsId { get; set; }

    }
}
