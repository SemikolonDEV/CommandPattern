using System;
using System.Collections.Generic;

// Command interface
interface ICommand {
    void Execute();
}

// Receiver classes
class Chef {
    public void Cook(string dish) {
        Console.WriteLine($"Cooking {dish}...");
    }
}

class Waiter {
    public void Serve(string dish) {
        Console.WriteLine($"Serving {dish}...");
    }
}

// Concrete command classes
class OrderCommand : ICommand {
    private Chef _chef;
    private Waiter _waiter;
    private string _dish;

    public OrderCommand(Chef chef, Waiter waiter, string dish) {
        _chef = chef;
        _waiter = waiter;
        _dish = dish;
    }

    public void Execute() {
        _chef.Cook(_dish);
        _waiter.Serve(_dish);
    }
}

// Invoker class
class OrderManager {
    private List<ICommand> _orders = new List<ICommand>();

    public void PlaceOrder(ICommand command) {
        _orders.Add(command);
        command.Execute();
    }
}

class Program {
    static void Main(string[] args) {
        Chef chef = new Chef();
        Waiter waiter = new Waiter();
        OrderManager orderManager = new OrderManager();

        ICommand order1 = new OrderCommand(chef, waiter, "Pasta");
        ICommand order2 = new OrderCommand(chef, waiter, "Steak");

        orderManager.PlaceOrder(order1);
        orderManager.PlaceOrder(order2);
    }
}