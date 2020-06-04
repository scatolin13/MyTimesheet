using M2RG.MyTimesheet.Flunt.Notifications;
using System;
using System.Linq.Expressions;

namespace M2RG.MyTimesheet.Flunt.Validations
{
    public partial class EntityBase : Notificable
    {
        public string EntityName => this.GetType().Name;

        public EntityBase Requires()
        {
            return this;
        }

        public EntityBase Join(params Notificable[] items)
        {
            if (items != null)
            {
                foreach (var notifiable in items)
                {
                    if (notifiable.IsInvalid)
                    {
                        AddNotifications(notifiable.Notifications);
                    }
                }
            }

            return this;
        }

        public EntityBase IfNotNull(object parameterType, Expression<Func<EntityBase, EntityBase>> contractExpression)
        {
            if (parameterType != null)
            {
                contractExpression.Compile().Invoke(this);
            }

            return this;
        }
    }
}
