namespace Task06
{
    public abstract class Creature
    {
        public string? Name { get; set; }
        public virtual void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Покидаю {this.Location}!");
        }
        protected string? Location { get; set; }
    }
    
    // 1) класс с данными о событии "Кольцо найдено"
    public class RingIsFoundEventArgs : EventArgs {
        public RingIsFoundEventArgs(string s) { Message = s; }
        // Будем передавать только строку
        public String Message { get; set; }
    }
    
    public class Wizard : Creature
    {
        //2) событийный делегат
        public new delegate void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs a);
        //3) событие "Кольцо найдено"
        public event RingIsFoundEventHandler? RaiseRingIsFoundEvent;
        public Wizard(string s) : this() { Name = s; }

        public Wizard()
        {
            Location = "Сады Лориэн";
        }
        // Когда волшебнику кажется, что кольцо найдено, он вызывает этот метод
        public void SomeThisIsChangedInTheAir() {
            Console.WriteLine($"{Name} >> Кольцо найдено у старого Бильбо! Призываю вас в Ривендейл! ");
            RaiseRingIsFoundEvent?.Invoke(this, new RingIsFoundEventArgs("Ривендейл"));
        }
    }
    
    public class Hobbit : Creature {
        public Hobbit(string s) { Name = s; }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e) {
            Console.WriteLine($"{Name} >> Покидаю Шир! Иду в " + e.Message);
            this.Location = e.Message;
        }
    }
    public class Human : Creature {
        public Human(string s)
        {
            Name = s;
            Location = "Минас Тирит";
        }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e) {
            Console.WriteLine($"{Name} >> Волшебник {((Wizard)sender).Name} позвал. Моя цель {e.Message}");
            Console.WriteLine($"{Name} >> Покидаю {this.Location}!");
            this.Location = e.Message;
        }
    }
    
    public class Elf : Creature {
        public Elf(string s) { 
            Name = s;
            Location = "Лихолесье";
        }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e) 	{
            Console.WriteLine($"{Name} >> Звёзды светят не так ярко как обычно. Цветы увядают. Листья предсказывают идти в " + e.Message);
            Console.WriteLine($"{Name} >> Покидаю {this.Location}!");
            this.Location = e.Message;
        }
    }
    public class Dwarf : Creature {
        public Dwarf(string s)
        {
            Name = s;
            Location = "Эребор";
        }
        public override void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e) {
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы! Выдвигаемся в " + e.Message);
            Console.WriteLine($"{Name} >> Покидаю {this.Location}!");
            this.Location = e.Message;
        }
    }
    
    class Program {
        static void Main()
        {
            var creatures = new List<Creature>(10);
            Wizard wizard = new("Гендальф");
            creatures.Add(wizard);
            creatures.Add(new Hobbit("Фродо"));
            creatures.Add(new Hobbit("Сэм"));
            creatures.Add(new Hobbit("Пипин"));
            creatures.Add(new Hobbit("Мэрри"));
            creatures.Add(new Human("Боромир"));
            creatures.Add(new Human("Арагорн"));
            creatures.Add(new Dwarf("Гимли"));
            creatures.Add(new Elf("Леголас"));
            
            foreach (var h in creatures)
                wizard.RaiseRingIsFoundEvent += h.RingIsFoundEventHandler;
            // волшебник оповещает всех 
            wizard.SomeThisIsChangedInTheAir();
        }
    }
}
