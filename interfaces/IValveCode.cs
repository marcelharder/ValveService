using ValveService.Data.dtos;

namespace ValveService.interfaces;

public interface IValveCode
{

    Task<List<Class_Item>> getValveCodesPerCountry(string currentCountry);
   
    Task<Valve_Code?> getDetailsByValveTypeId(int ValveTypeId);
    Task<Valve_Code?> getDetailsByNo(int code);
    Task<Valve_Code?> getDetailsByProductCode(string code);

    Task<List<Valve_Code>?> getAllProducts();
    Task<List<ValveCodeSizesDTO>?> getValveCodeSizes(int id);
    Task<List<Valve_Code>?> getAllProductsByVTP(string vendor, string type, string position);
    Task<List<Valve_Code>> GetValveCodesInHospital(string type, string location, int hospitalId);
    Task<List<Class_Item>> GetValveCodesNOTinHospital(string type, string location, int hospitalId);
    Task<string> addHospitalIdToValveCode(int ValveTypeId, int hospitalId);
    Task<List<Class_Item>> getAllTPProducts(string position, string type);
    Task<Valve_Code?> addValveCode(Valve_Code vc);
    Task<Valve_Code> updateValveCode(Valve_Code vc);
    Task<int> deleteValveCode(int id);
    Task<Valve_Size?> getSize(int cid);

















}