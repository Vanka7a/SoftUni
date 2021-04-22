﻿using AutoMapper;
using RealEstates.Services.Profiler;
using System;

namespace RealEstates.Services
{
    public abstract class BaseService
    {
        protected IMapper Mapper { get; private set; }

        public BaseService()
        {
            InitializeAutoMapper();
        }

        private void InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<RealEstateProfiler>();
            });
        }
    }
}
