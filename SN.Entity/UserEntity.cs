﻿namespace SN.Entity
{
    public class UserEntity: Entity
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Likes { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }

        public int RankId { get; set; }
        public RankEntity Rank { get; set; }
    }
}