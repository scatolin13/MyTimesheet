using M2RG.MyTimesheet.RequestResponse.BaseDtos;
using M2RG.MyTimesheet.RequestResponse.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace M2RG.MyTimesheet.RequestResponse
{
    public class ResultDefault<T> : IResultDefault
    {
        /// <summary>
        /// Valor do resultado, sempre uma coleção IEnumerable do tipo informado T
        /// </summary>
        public IEnumerable<T> Value { get; set; } = new List<T>();

        /// <summary>
        /// Mensagens do resultado, coleção contendo Sucess e Warning
        /// </summary>
        public MessageList Messages { get; set; } = new MessageList();

        /// <summary>
        /// Exceptions lançadas na comunicação com o endpoint endpoint
        /// </summary>
        public List<string> Exceptions { get; set; } = new List<string>();

        /// <summary>
        /// Dados do contexto para validação, a quem pertence essa informação
        /// </summary>
        public ContextData ContextData { get; set; } = new ContextData();

        public class MessageList : List<Message>
        {
            public void Add(MessageType messageType, string value)
            {
                base.Add(new Message()
                {
                    MessageText = value,
                    MessageType = messageType
                });
            }

            public void AddRange(MessageType messageType, IEnumerable<Notification> notifications)
            {
                if (notifications != null)
                {
                    foreach (var notification in notifications)
                    {
                        base.Add(new Message()
                        {
                            MessageText = notification.Message,
                            MessageType = messageType
                        });
                    }
                }
            }
        }

        public class Message
        {
            public MessageType MessageType { get; set; } = MessageType.Success;
            public string MessageText { get; set; }
        }
    }
}
