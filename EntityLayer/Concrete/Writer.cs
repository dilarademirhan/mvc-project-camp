﻿namespace EntityLayer.Concrete
{
    public class Writer
    {
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterImage { get; set; }
        public string WriterAbout { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public string WriterTitle { get; set; }
        public bool WriterStatus { get; set; }
        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
