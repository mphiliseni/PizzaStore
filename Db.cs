namespace PizzaStore.Db;

public record Pizza{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class PizzaDb{
    // This code defines a Pizza record and PizzaDb class in the PizzaStore.Db namespace
    // The Pizza record has two properties:
    // - Id: An integer identifier for the pizza
    // - Name: A string containing the pizza's name and description

    // The PizzaDb class contains a private static List of Pizza objects
    // that serves as an in-memory database of 4 pre-defined pizzas:
    // 1. The Montemagno - Mountain shaped
    // 2. The Galloway - Submarine shaped  
    // 3. The Noring - Viking helmet shaped
    // 4. Meat - Meatball shaped        
private static List<Pizza> _pizzas = new  List<Pizza>(){
        new Pizza{Id = 1, Name = "Montemagno, Pizza shaped like a great mountain"},
        new Pizza{Id = 2, Name = "The Galloway, Pizza shaped like a submarine, silent but deadly"},
        new Pizza{Id = 3, Name = "The Noring, Pizza shaped like a Viking helmet, where's the mead"},
        new Pizza{Id = 4, Name = "Meat, Pizza shaped like a meatball, where's the sauce"},
        new Pizza{Id = 5, Name = "The Galloway, Pizza shaped like a submarine, silent but deadly"},
        new Pizza{Id = 6, Name = "The Noring, Pizza shaped like a Viking helmet, where's the mead"},
    };

    public static List<Pizza> GetPizzas(){
        // This method returns the list of pizzas
        return _pizzas;
    }
    public static Pizza? GetPizza(int Id){
        // This method returns a pizza with the specified Id
        return _pizzas.SingleOrDefault(p => p.Id == Id);
    }
    public static Pizza CreatePizza(Pizza pizza){
        // This method adds a new pizza to the list
        _pizzas.Add(pizza);
        return pizza;
    }
    public static Pizza UpdatePizza(Pizza update){
        // This method updates an existing pizza with the specified Id
        _pizzas = _pizzas.Select(Pizza =>{
            if (Pizza.Id == update.Id){
                Pizza.Name = update.Name;
            }
            return Pizza;
        }).ToList();
        return update;
        }
        public static void RemovePizza (int Id){
            // This method removes a pizza with the specified Id from the list
          _pizzas = _pizzas.FindAll(Pizza => Pizza.Id != Id).ToList(); 
        }
 }