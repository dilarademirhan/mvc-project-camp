﻿namespace EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime ContactDate { get; set; }

    }
}
