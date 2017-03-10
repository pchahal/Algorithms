using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using static GameProgrammingPatterns.Instruction;

/*An instruction set defines the low-level operations that can be performed. 
A series of instructions is encoded as a sequence of bytes. A virtual machine executes these instructions
one at a time, using a stack for intermediate values. 
By combining instructions, complex high-level behavior can be defined.*/

namespace GameProgrammingPatterns
{
    public enum Instruction
    {
        INST_SET_HEALTH = 0x00,
        INST_SET_WISDOM = 0x01,
        INST_SET_AGILITY = 0x02,
        INST_PLAY_SOUND = 0x03,
        INST_SPAWN_PARTICLES = 0x04,
        INST_LITERAL =0x05,

        INST_GET_HEALTH = 0x06,
        INST_ADD = 0x07,
    };

    public class VM
    {
        private Stack<int> stack = new Stack<int>();
        public string result { get; set; }

        public void interpret(byte[] bytecode, int size)
        {
            for (int i = 0; i < size; i++)
            {
                byte instruction = bytecode[i];
                switch (instruction)
                {
                    case (byte) INST_SET_HEALTH:
                        int amount = stack.Pop();
                        int wizard = stack.Pop();
                        setHealth(amount, wizard);
                        break;
                    case (byte)INST_GET_HEALTH:
                       
                        wizard = stack.Pop();
                        stack.Push(getHealth(wizard));
                       
                        break;
                    case (byte) INST_SET_WISDOM:
                         amount = stack.Pop();
                         wizard = stack.Pop();
                        setWisdom(amount, wizard);
                        break;

                    case (byte) INST_SET_AGILITY:
                         amount = stack.Pop();
                         wizard = stack.Pop();
                        setAgility(amount, wizard);
                        break;

                    case (byte) INST_PLAY_SOUND:
                        playSound(stack.Pop());
                        break;

                    case (byte) INST_SPAWN_PARTICLES:
                        spawnParticles(stack.Pop() );
                        break;
                    case (byte)INST_LITERAL:
                        {
                            // Read the next byte from the bytecode.
                            int value = bytecode[++i];
                            stack.Push(value);
                            break;
                        }
                    case (byte)INST_ADD:
                        {
                            int b = stack.Pop();
                            int a = stack.Pop();
                            stack.Push(a + b);
                            break;
                        }

                }
            }
        }

        private int getHealth(int wizard)
        {
            return 0;
        }

        private void spawnParticles(int particle)
        {
            result = "setwisdom" + particle;
        }

        private void playSound(int sound)
        {
            result = "setwisdom" + sound ;
        }

        private void setAgility(int v1, int v2)
        {
            result = "setwisdom" + v1 + v2;
        }

        private void setWisdom(int v1, int v2)
        {
            result = "setwisdom" + v1 + v2;
        }

        private void setHealth(int v1, int v2)
        {
            result= "sethealth" + v1 + v2;
        }
    };



}
