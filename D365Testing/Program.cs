using System;
using ServiceStack;
using ServiceStack.Text;

namespace D365Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = @"{
    '@odata.type': '#NAV.PurchaseInvoice',
    'Area': 'Area1',
    'Assigned_User_ID': null,
    'Buy_from_Address': null,
    'Buy_from_Address_2': null,
    'Buy_from_City': null,
    'Buy_from_Contact': null,
    'Buy_from_Contact_No': null,
    'Buy_from_Country_Region_Code': null,
    'Buy_from_County': null,
    'Buy_from_Post_Code': null,
    'Buy_from_Vendor_Name': 'Graphic Design Institute',
    'Buy_from_Vendor_No': '30000',
    'BuyFromContactEmail': null,
    'BuyFromContactMobilePhoneNo': null,
    'BuyFromContactPhoneNo': null,
    'Campaign_No': null,
    'Creditor_No': null,
    'Currency_Code': null,
    'DIOT_Type_of_Operation': null,
    'Document_Date': '2021-06-17',
    'Document_Type': 'Invoice',
    'Due_Date': null,
    'Entry_Point': null,
    'Expected_Receipt_Date': null,
    'Fiscal_Invoice_Number_PAC': null,
    'Incoming_Document_Entry_No': null,
    'IRS_1099_Code': null,
    'Job_Queue_Status': null,
    'Location_Code': null,
    'No': '',
    'On_Hold': null,
    'Order_Address_Code': null,
    'Pay_to_Address': '33 Hitech Drive',
    'Pay_to_Address_2': '',
    'Pay_to_City': 'Miami',
    'Pay_to_Contact': null,
    'Pay_to_Contact_No': 'CT000015',
    'Pay_to_Country_Region_Code': 'US',
    'Pay_to_County': 'FL',
    'Pay_to_Name': 'Graphic Design Institute',
    'Pay_to_Post_Code': '37125',
    'Payment_Discount_Percent': null,
    'Payment_Method_Code': null,
    'Payment_Reference': 'POERef',
    'Payment_Terms_Code': null,
    'PayToContactEmail': null,
    'PayToContactMobilePhoneNo': null,
    'PayToContactPhoneNo': null,
    'PayToOptions': 'Another Vendor',
    'Pmt_Discount_Date': null,
    'Posting_Date': '2021-06-17',
    'Posting_Description': 'Posting desc',
    'Prices_Including_VAT': null,
    'Provincial_Tax_Area_Code': null,
    'Purchaser_Code': null,
    'Reason_Code': null,
    'Responsibility_Center': null,
    'Ship_to_Address': '730 17th st STE 690',
    'Ship_to_Address_2': null,
    'Ship_to_City': 'Denver',
    'Ship_to_Contact': null,
    'Ship_to_Country_Region_Code': 'US',
    'Ship_to_County': 'CO',
    'Ship_to_Name': 'Alpha Flowback Corp',
    'Ship_to_Post_Code': '80202',
    'Ship_to_UPS_Zone': null,
    'Shipment_Method_Code': '',
    'ShippingOptionWithLocation': null,
    'Shortcut_Dimension_1_Code': null,
    'Shortcut_Dimension_2_Code': null,
    'Status': null,
    'Tax_Area_Code': null,
    'Tax_Exemption_No': null,
    'Tax_Liable': null,
    'Transaction_Specification': null,
    'Transaction_Type': null,
    'Transport_Method': null,
    'VAT_Bus_Posting_Group': null,
    'Vendor_Invoice_No': 'VendorInvNo',
    'Vendor_Order_No': null
}";


        try { 
        var data = "https://api.businesscentral.dynamics.com/v2.0/5e028012-a467-44c6-8084-34e9fb6d84a8/Production/ODataV4/Company('CRONUS%20USA%2C%20Inc.')/PurchaseInvoice"
                .PostJsonToUrl(json, requestFilter: (req) =>
                {
                    
                    req.Headers.Add("Authorization", "basic [yourvalue]");
                },
                responseFilter: httpRes => {
                    var h = httpRes.StatusCode;
                });
                Console.WriteLine(data);
            } catch (Exception ex)
            {
                var body = ex.GetResponseBody();
                Console.WriteLine(body);
            }

         
            Console.ReadKey();
        }
    }
}
