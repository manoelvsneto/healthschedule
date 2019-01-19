using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Health.Schedule.Shared
{
    [Serializable]
    [Table("USER")]
    public class User
    {
        [Key]
        [Column("ID_USER")]
        public Int64 Identificador { get; set; }
        [Column("PASSWORD")]
        public string Password { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("USER_GUID")]
        public string UserGuid { get; set; }
    }
    [Serializable]
    public class ListUser : List<User>
    {
    }
}
