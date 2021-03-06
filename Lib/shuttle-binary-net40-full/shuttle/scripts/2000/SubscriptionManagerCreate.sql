CREATE TABLE [dbo].[SubscriberMessageType](
	[MessageType] [varchar](250) NOT NULL,
	[InboxWorkQueueUri] [varchar](130) NOT NULL,
	[AcceptedBy] [varchar](250) NULL,
	[AcceptedDate] [datetime] NULL,
 CONSTRAINT [PK_SubscriberMessageType] PRIMARY KEY CLUSTERED 
(
	[MessageType] ASC,
	[InboxWorkQueueUri] ASC
) ON [PRIMARY]
) ON [PRIMARY]
GO
