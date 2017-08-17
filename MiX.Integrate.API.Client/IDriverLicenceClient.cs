﻿using MiX.Integrate.Shared.Entities.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiX.Integrate.Api.Client
{
	public interface IDriverLicenceClient
	{
		IList<DriverLicence> GetDriverLicencesByDriverId(long organisationGroupId, long driverId);
		Task<IList<DriverLicence>> GetDriverLicencesByDriverIdAsync(long organisationGroupId, long driverId);

		DriverLicence GetDriverLicenceById(long organisationGroupId, long driverId, int licenceCategoryId);
		Task<DriverLicence> GetDriverLicenceByIdAsync(long organisationGroupId, long driverId, int licenceCategoryId);

		IList<LicenceCategory> GetDriverLicenceCategories(long organisationGroupId, long driverId);
		Task<IList<LicenceCategory>> GetDriverLicenceCategoriesAsync(long organisationGroupId, long driverId);

		void AddDriverLicence (long organisationGroupId, DriverLicence driverLicence);
		Task AddDriverLicenceAsync(long organisationGroupId, DriverLicence driverLicence);

		void UpdateDriverLicence (long organisationGroupId, DriverLicence driverLicence);
		Task UpdateDriverLicenceAsync(long organisationGroupId, DriverLicence driverLicence);

		void DeleteDriverLicence (long organisationGroupId, long driverId, int licenceCategoryId);
		Task DeleteDriverLicenceAsync(long organisationGroupId, long driverId, int licenceCategoryId);
	}
}