using HueApi.Models;
using HueApi.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueApi.Extensions
{
  public static class BaseHueApiExtensions
  {
    public static Task<HuePutResponse> SetStreamingAsync(this BaseHueApi hueApi, Guid entertainmentAreaId)
    {
      UpdateEntertainmentConfiguration req = new UpdateEntertainmentConfiguration()
      {
        Action = EntertainmentConfigurationAction.start
      };

      return hueApi.UpdateEntertainmentConfigurationAsync(entertainmentAreaId, req);
    }
  }
}
