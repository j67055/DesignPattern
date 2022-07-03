using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            Character character = new Character();
            character.addBuff("공격력 증가");
            character.showBuffs();

            Console.WriteLine("     !첫 번째 상태 저장!\n");
            logger.add(character.createMemento());

            character.removeBuff("공격력 증가");
            character.addBuff("이동 속도 증가");
            character.addBuff("최대 체력 증가");
            character.showBuffs();

            Console.WriteLine("     !두 번째 상태 저장!\n");
            logger.add(character.createMemento());

            Console.WriteLine("\n     *첫 번째 상태 로드*");
            character.setMemento(logger.get(0));
            character.showBuffs();

            Console.WriteLine("\n     *두 번째 상태 로드*");
            character.setMemento(logger.get(1));
            character.showBuffs();
        }
    }
}
