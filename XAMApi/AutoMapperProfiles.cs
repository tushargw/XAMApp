using AutoMapper;

namespace XAMApi
{
	public class AutoMapperProfiles : Profile
	{
		public AutoMapperProfiles()
		{
			CreateMap<XAMApi.Models.Restaurant, XAMApiContracts.DTOs.Restaurant>()
				.ForMember(dest => dest.AdminId, opt => opt.MapFrom(src => src.ModifiedBy))
				.ReverseMap()
				.ForMember(dest => dest.ModifiedBy, opt => opt.MapFrom(src => src.AdminId));
			CreateMap<XAMApi.Models.User, XAMApiContracts.DTOs.User>();
		}
	}
}
