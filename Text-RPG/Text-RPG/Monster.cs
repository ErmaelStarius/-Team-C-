using System.ComponentModel;

namespace Text_RPG
{
    internal class Monster
    {
        public string Name { get; } //몬스터 이름
        public float Atk { get; } //공격력
        public float Def { get; } //방어력
        public float Hp { get; } //체력
        public string SkillName { get; } //스킬이름
        public float SkillAtk { get; } //스킬 공격
        public float Gold { get; set; } // 잡을시 골드

        public float Exp { get; } // 잡을시 경험치

        //생성자의 용도 = 기본세팅
        public Monster(string name, float atk, float def, float hp, string skillname , float skillatk, float gold, float exp)
        {
            Name = name;
            Atk = atk;
            Def = def;
            Hp = hp;
            SkillName = skillname;
            SkillAtk = skillatk;
            Gold = gold;
            Exp = exp;
        }
        
        
        internal static void InitializeGame(string name, float atk, float def, float hp, string skillname, float skillatk, float gold, float exp)
        {
                 
        }
    }
}