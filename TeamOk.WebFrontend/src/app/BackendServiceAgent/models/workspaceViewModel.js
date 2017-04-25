/*
 * Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

var models = require('./index');

var util = require('util');

/**
 * @class
 * Initializes a new instance of the WorkspaceViewModel class.
 * @constructor
 * @member {number} [id]
 * 
 * @member {number} [floorId]
 * 
 * @member {string} [name]
 * 
 * @member {boolean} [claimed]
 * 
 * @member {date} [claimedUntill]
 * 
 * @member {array} [facilities]
 * 
 * @member {date} [created]
 * 
 * @member {date} [modified]
 * 
 */
function WorkspaceViewModel() {
}

/**
 * Defines the metadata of WorkspaceViewModel
 *
 * @returns {object} metadata of WorkspaceViewModel
 *
 */
WorkspaceViewModel.prototype.mapper = function () {
  return {
    required: false,
    serializedName: 'WorkspaceViewModel',
    type: {
      name: 'Composite',
      className: 'WorkspaceViewModel',
      modelProperties: {
        id: {
          required: false,
          serializedName: 'id',
          type: {
            name: 'Number'
          }
        },
        floorId: {
          required: false,
          serializedName: 'floorId',
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
        claimed: {
          required: false,
          serializedName: 'claimed',
          type: {
            name: 'Boolean'
          }
        },
        claimedUntill: {
          required: false,
          serializedName: 'claimedUntill',
          type: {
            name: 'DateTime'
          }
        },
        facilities: {
          required: false,
          serializedName: 'facilities',
          type: {
            name: 'Sequence',
            element: {
                required: false,
                serializedName: 'FacilityViewModelElementType',
                type: {
                  name: 'Composite',
                  className: 'FacilityViewModel'
                }
            }
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

module.exports = WorkspaceViewModel;
