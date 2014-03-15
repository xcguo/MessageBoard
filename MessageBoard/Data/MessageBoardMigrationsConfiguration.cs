using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace MessageBoard.Data
{
    class MessageBoardMigrationsConfiguration 
        : DbMigrationsConfiguration<MessageBoardContext>
    {
        public MessageBoardMigrationsConfiguration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MessageBoardContext context)
        {
            base.Seed(context);
#if DEBUG
            if(context.Topics.Count() == 0)
            {
                var topic = new Topic()
                {
                    Title = "I like BURBERRY",
                    Created = DateTime.Now,
                    Body = "I like Trenchcoat",
                    Replies = new List<Reply>()
                    {
                        new Reply()
                        {
                            Body = "I like it too",
                            Created= DateTime.Now
                        },
                        new Reply()
                        {
                            Body = "Me too",
                            Created = DateTime.Now
                        }
                    }

                };
                context.Topics.Add(topic);
                try
                {
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    var message = ex.Message;
                }
            }
            
#endif
        
        }
    }
}
