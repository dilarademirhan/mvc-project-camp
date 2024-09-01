﻿namespace EntityLayer.Concrete
{
	public class Message
	{
		public int MessageId { get; set; }
		public string SenderMail { get; set; }
		public string ReceiverMail { get; set; }
		public string Subject { get; set; }
		public string MessageContent { get; set; }
		public DateTime MessageDate { get; set; }
	}

}
