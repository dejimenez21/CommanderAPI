using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command{Id=0, Howto="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id=1, Howto="Cut bread", Line="Get a knife", Platform="Pizzarelli"},
                new Command{Id=2, Howto="Wash the dishes", Line="Take a sponge", Platform="KFC"}
                
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, Howto="Boil an egg", Line="Boil water", Platform="Kettle & Pan"};
        }
    }
}