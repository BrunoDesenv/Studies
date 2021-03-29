using Reflection.Game.Personages;

namespace Reflection.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var fighterCombat = new Combat(new Fighter());
            var wizardCombat = new Combat(new Thief());


            fighterCombat.RearAttack();
            wizardCombat.RearAttack();
        }
    }
}
