namespace Text_RPG
{
    public class Player
    {
        
        //생성자이후에 Set하지 않겠다! => 읽기 전용이라는 말
        public string Name { get; } //캐릭터명
        public string Job { get; } //직업
        public int Level { get; } //레벨
        public int Exp { get; } //경험치
        public int Atk { get; } //공격력
        public int Def { get; } //방어력
        public int Hp { get; } //체력
        public int Mp { get; } //마나
        public int Gold { get; set; } //소지금

        //생성자의 용도 = 기본세팅
        public Player(string name, string job, int level, int exp,int attack, int deffence, int hp, int mp, int gold)
        {
            Name = name;
            Job = job;
            Level = level;
            Exp = exp;
            Atk = attack;
            Def = deffence;
            Hp = hp;
            Mp = mp;
            Gold = gold;
        }
      
    }
}