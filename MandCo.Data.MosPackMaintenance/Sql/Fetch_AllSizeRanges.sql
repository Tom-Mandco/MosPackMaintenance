Select Distinct sr.size_range              "Size_Range",
				sr.size_range_description  "Size_Range_Description",
				sr.dss_department_code     "Department_Code",
				sr.dss_sub_department_code "Sub_Department_Code"
From	 shp_size_range sr
Order By		sr.dss_department_code,
				sr.dss_sub_department_code,
				sr.size_range Desc