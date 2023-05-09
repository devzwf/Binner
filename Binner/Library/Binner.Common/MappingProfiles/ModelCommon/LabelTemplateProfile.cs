﻿using AutoMapper;
using Binner.Model;
using DataModel = Binner.Data.Model;

namespace Binner.Common.MappingProfiles.ModelCommon
{
    public class LabelTemplateProfile : Profile
    {
        public LabelTemplateProfile()
        {
            CreateMap<LabelTemplate, DataModel.LabelTemplate>()
                .ForMember(x => x.Name, options => options.MapFrom(x => x.Name))
                .ForMember(x => x.LabelPaperSource, options => options.MapFrom(x => x.LabelPaperSource))
                .ForMember(x => x.Width, options => options.MapFrom(x => x.Width))
                .ForMember(x => x.Height, options => options.MapFrom(x => x.Height))
                .ForMember(x => x.Margin, options => options.MapFrom(x => x.Margin))
                .ForMember(x => x.Dpi, options => options.MapFrom(x => x.Dpi))
                .ForMember(x => x.LabelTemplateId, options => options.Ignore())
                .ForMember(x => x.UserId, options => options.Ignore())
                .ForMember(x => x.OrganizationId, options => options.Ignore())
                .ForMember(x => x.DateCreatedUtc, options => options.Ignore())
                .ForMember(x => x.DateModifiedUtc, options => options.Ignore())
                .ForMember(x => x.Labels, options => options.Ignore())
                ;

            CreateMap<DataModel.LabelTemplate, LabelTemplate>()
                .ForMember(x => x.LabelTemplateId, options => options.MapFrom(x => x.LabelTemplateId))
                .ForMember(x => x.Name, options => options.MapFrom(x => x.Name))
                .ForMember(x => x.LabelPaperSource, options => options.MapFrom(x => x.LabelPaperSource))
                .ForMember(x => x.Width, options => options.MapFrom(x => x.Width))
                .ForMember(x => x.Height, options => options.MapFrom(x => x.Height))
                .ForMember(x => x.Margin, options => options.MapFrom(x => x.Margin))
                .ForMember(x => x.Dpi, options => options.MapFrom(x => x.Dpi))
                ;
        }
    }
}
