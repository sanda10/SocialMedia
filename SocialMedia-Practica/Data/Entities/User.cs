﻿namespace Practica.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }


        public string HashedPassword { get; set; }
            

        public DateTime BirthDate { get; set; }
                
        public ICollection<Post> Posts { get; set; }
    }
}
