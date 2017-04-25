/*
 * Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * @class
 * Initializes a new instance of the FacilityViewModel class.
 * @constructor
 * @member {number} [id]
 * 
 * @member {string} [name]
 * 
 * @member {string} [value]
 * 
 * @member {date} [created]
 * 
 * @member {date} [modified]
 * 
 */
function FacilityViewModel() {
}

/**
 * Defines the metadata of FacilityViewModel
 *
 * @returns {object} metadata of FacilityViewModel
 *
 */
FacilityViewModel.prototype.mapper = function () {
  return {
    required: false,
    serializedName: 'FacilityViewModel',
    type: {
      name: 'Composite',
      className: 'FacilityViewModel',
      modelProperties: {
        id: {
          required: false,
          serializedName: 'id',
          type: {
            name: 'Number'
          }
        },
        name: {
          required: false,
          serializedName: 'name',
          type: {
            name: 'String'
          }
        },
        value: {
          required: false,
          serializedName: 'value',
          type: {
            name: 'String'
          }
        },
        created: {
          required: false,
          serializedName: 'created',
          type: {
            name: 'DateTime'
          }
        },
        modified: {
          required: false,
          serializedName: 'modified',
          type: {
            name: 'DateTime'
          }
        }
      }
    }
  };
};

module.exports = FacilityViewModel;
