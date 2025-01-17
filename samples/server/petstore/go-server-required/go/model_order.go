/*
 * OpenAPI Petstore
 *
 * This is a sample server Petstore server. For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * API version: 1.0.0
 * Generated by: OpenAPI Generator (https://openapi-generator.tech)
 */

package petstoreserver

import (
	"time"
)

// Order - An order for a pets from the pet store
type Order struct {
	SpecialInfo

	Id int64 `json:"id,omitempty"`

	// Order Status
	Status string `json:"status,omitempty"`

	Complete bool `json:"complete,omitempty"`

	Comment *string `json:"comment"`

	PetId int64 `json:"petId,omitempty"`

	Quantity int32 `json:"quantity,omitempty"`

	ShipDate time.Time `json:"shipDate,omitempty"`
}

// AssertOrderRequired checks if the required fields are not zero-ed
func AssertOrderRequired(obj Order) error {
	elements := map[string]interface{}{
		"comment": obj.Comment,
	}
	for name, el := range elements {
		if isZero := IsZeroValue(el); isZero {
			return &RequiredError{Field: name}
		}
	}

	if err := AssertSpecialInfoRequired(obj.SpecialInfo); err != nil {
		return err
	}

	return nil
}
