﻿using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class Contact
    {
        public required int contactId { get; set; }

        public virtual required User user_Id { get; set; }

        public required string contactType { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
