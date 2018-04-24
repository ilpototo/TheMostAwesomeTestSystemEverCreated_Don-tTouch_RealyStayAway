﻿using ITest.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITest.DTO
{
    public class UserTestsDTO
    {
        public string UserId { get; set; }

        public User User { get; set; }

        public int TestId { get; set; }

        public Test Test { get; set; }

        public decimal Result { get; set; }

        public List<string> StorageOfAnswers { get; set; }

        //Think about this id
        public int Id { get; set; }
    }
}