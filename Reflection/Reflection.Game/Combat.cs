using Reflection.Game.Personages;
using System;
using System.Reflection;

namespace Reflection.Game
{
    public class Combat
    {
        private Character currentCharacter;


        public Combat(Character character)
        {
            currentCharacter = character;
        }

        public void RearAttack()
        {
            var typeCharacter = currentCharacter.GetType();

            MethodInfo methods = typeCharacter.GetMethod("BackStab");

            if (methods == null)
            {
                currentCharacter.Attack();
            }
            else
            {
                methods.Invoke(currentCharacter, null);
            }
        }

    }
}
