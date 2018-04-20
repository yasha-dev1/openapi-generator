/**
* Swagger Petstore
* This is a sample server Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/).  For this sample, you can use the api key `special-key` to test the authorization filters.
*
* OpenAPI spec version: 1.0.0
* Contact: apiteam@swagger.io
*
* NOTE: This class is auto generated by the swagger code generator program.
* https://github.com/swagger-api/swagger-codegen.git
* Do not edit the class manually.
*/

/*
* PetApiImpl.h
*
* 
*/

#ifndef PET_API_IMPL_H_
#define PET_API_IMPL_H_


#include <pistache/endpoint.h>
#include <pistache/http.h>
#include <pistache/router.h>
#include <memory>

#include <PetApi.h>

#include "ApiResponse.h"
#include "Pet.h"
#include <string>

namespace io {
namespace swagger {
namespace server {
namespace api {

using namespace io::swagger::server::model;

class PetApiImpl : public io::swagger::server::api::PetApi {
public:
    PetApiImpl(Pistache::Address addr);
    ~PetApiImpl() { };

    void add_pet(const std::shared_ptr<Pet> &pet, Pistache::Http::ResponseWriter &response);
    void delete_pet(const int64_t &petId, const Optional<Net::Http::Header::Raw> &apiKey, Pistache::Http::ResponseWriter &response);
    void find_pets_by_status(const Optional<std::string> &status, Pistache::Http::ResponseWriter &response);
    void find_pets_by_tags(const Optional<std::string> &tags, Pistache::Http::ResponseWriter &response);
    void get_pet_by_id(const int64_t &petId, Pistache::Http::ResponseWriter &response);
    void update_pet(const std::shared_ptr<Pet> &pet, Pistache::Http::ResponseWriter &response);
    void update_pet_with_form(const Pistache::Rest::Request &request, Pistache::Http::ResponseWriter &response);
    void upload_file(const Pistache::Rest::Request &request, Pistache::Http::ResponseWriter &response);

};

}
}
}
}



#endif