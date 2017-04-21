Select rdept.dss_department_code			  "Department",
			 rdept.description                "Department_Description",
			 rsubdept.dss_sub_department_code "Sub_Department",
			 rsubdept.description             "Sub_Department_Description",
			 rsection.dss_section_code        "Section",
			 rsection.description             "Section_Description",
			 rrange.dss_range_code            "Range",
			 rrange.description               "Range_Description",
			 rsubrange.dss_sub_range_code     "Sub_Range",
			 rsubrange.description            "Sub_Range_Description"
From ref_departments		 rdept,
		 ref_sub_departments rsubdept,
		 ref_sections        rsection,
		 ref_ranges          rrange,
		 ref_sub_ranges      rsubrange
Where rsubdept.dss_department_code = rdept.dss_department_code
And rsection.dss_department_code = rdept.dss_department_code
And rsection.dss_sub_department_code = rsubdept.dss_sub_department_code
And rrange.dss_department_code = rdept.dss_department_code
And rrange.dss_sub_department_code = rsubdept.dss_sub_department_code
And rrange.dss_section_code = rsection.dss_section_code
And rsubrange.dss_department_code = rdept.dss_department_code
And rsubrange.dss_sub_department_code = rsubdept.dss_sub_department_code
And rsubrange.dss_section_code = rsection.dss_section_code
And rsubrange.dss_range_code = rrange.dss_range_code;