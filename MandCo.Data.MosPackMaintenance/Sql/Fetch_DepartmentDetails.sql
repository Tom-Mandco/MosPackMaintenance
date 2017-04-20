Select unique (product.dss_department_code || product.dss_subdepartment_code || product.dss_section_code || product.dss_range_code || product.dss_subrange_code) "Department",
       dept.description "Department_Description",
       subRange.description "SubRange_Description"
From war_hir_pack_match packMatch,
     ref_product        product,
     ref_sub_ranges     subRange,
     ref_departments    dept
Where packMatch.pack_id = @0
And packMatch.product_number = product.product_number
And product.dss_department_code = subRange.dss_department_code
And product.dss_subdepartment_code = subRange.dss_sub_department_code
And product.dss_section_code = subRange.dss_section_code
And product.dss_range_code = subRange.dss_range_code
And product.dss_subrange_code = subRange.dss_sub_range_code
And product.dss_department_code = dept.dss_department_code
Order by "Department" Asc