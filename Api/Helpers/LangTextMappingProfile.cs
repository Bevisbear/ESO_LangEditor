﻿using AutoMapper;
using Core.Entities;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class LangTextMappingProfile : Profile
    {
        public LangTextMappingProfile()
        {
            CreateMap<LangText, LangTextDto>();
            CreateMap<LangText, LangTextReview>();
            CreateMap<LangText, LangTextArchive>();
            CreateMap<LangTextForCreationDto, LangText>();
            CreateMap<LangTextForUpdateZhDto, LangText>();
            CreateMap<LangTextForCreationDto, LangTextReview>();
            CreateMap<LangTextForUpdateZhDto, LangTextReview>();
            CreateMap<LangTextForUpdateEnDto, LangTextReview>();
            CreateMap<LangTextReview, LangText>();
            CreateMap<LangTextReview, LangTextForReviewDto>();
            CreateMap<LangTextReview, LangTextArchive>();
            CreateMap<LangTextArchive, LangTextForArchiveDto>();
            CreateMap<LangTextRevisedDto, LangTextRevised>();
            CreateMap<LangTextRevised, LangTextRevisedDto>();
            //CreateMap<LangTextRevNumberDto, LangTextRevNumber>();
            CreateMap<LangTextRevNumber, LangTextRevNumberDto>();
            CreateMap<User, UserDto>();
            CreateMap<User, UserInClientDto>();
            CreateMap<UserProfileModifyBySelfDto, User>();
            CreateMap<LangTypeCatalog, LangTypeCatalogDto>();
            CreateMap<LangTypeCatalogReview, LangTypeCatalog>();
            CreateMap<LangTypeCatalogReview, LangTypeCatalogDto>();
            CreateMap<LangTypeCatalogDto, LangTypeCatalog>();
            CreateMap<LangTypeCatalogDto, LangTypeCatalogReview>();
            CreateMap<GameVersion, GameVersionDto>();
            CreateMap<GameVersionDto, GameVersion>();
        }
    }
}
