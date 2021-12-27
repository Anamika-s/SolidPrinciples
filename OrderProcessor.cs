using System;

class OrderProcessor()
{
  // Validation
  // Save
  // Notifications
  OrderValidator _orderValidator;
  ISaveOrder[] _saveOrder;
  NotificationMessages _notificationMessages; 
   
  public OrderProcessor(OrderValidator orderValidator, 
  IOrderSaver[] saveOrder, NotificationMessages notificationMessages) 
  {
    _orderValidator = orderValidator;
    _saveOrder = saveOrder;
    _notificationMessages = notificationMessages;

  }
  public void Process()
  {
    _orderValidator.Validate();
    foreach(var source in saveOrder)
    {
    source.Save(null);
    }
    _notificationMessages.SendNotification();
  }
 
}

public class OrderValidator 
{
 public void Validate() {}
}

public interface IOrderSaver
{
  void Save(string order);
}
public class DbOrderSaver : IOrderSaver
{
public void Save(string order){}
//public void SaveToCache(string order){}
}

public class CacheOrderSaver : IOrderSaver
{
public void Save(string order){}

}



public class NotificationMessages()
{
 public void SendNotification(){}
}
