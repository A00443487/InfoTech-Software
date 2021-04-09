import React from 'react';
import classNames from 'classnames';
import { SectionTilesProps } from '../../utils/SectionProps';
import SectionHeader from './partials/SectionHeader';
import Image from '../elements/Image';

const propTypes = {
  ...SectionTilesProps.types
}

const defaultProps = {
  ...SectionTilesProps.defaults
}
const FeaturesTiles = ({
  className,
  topOuterDivider,
  bottomOuterDivider,
  topDivider,
  bottomDivider,
  hasBgColor,
  invertColor,
  pushLeft,
  ...props
}) => {

  const outerClasses = classNames(
    'features-tiles section',
    topOuterDivider && 'has-top-divider',
    bottomOuterDivider && 'has-bottom-divider',
    hasBgColor && 'has-bg-color',
    invertColor && 'invert-color',
    className
  );

  const innerClasses = classNames(
    'features-tiles-inner section-inner pt-0',
    topDivider && 'has-top-divider',
    bottomDivider && 'has-bottom-divider'
  );

  const tilesClasses = classNames(
    'tiles-wrap center-content',
    pushLeft && 'push-left'
  );

  const sectionHeader = {
    title: 'About Us',
    paragraph: 'HRP provides an individual scope for following three components of the system'
  };

  return (
    <section
      {...props}
      className={outerClasses}
    >
      <div className="container">
        <div className={innerClasses}>
                  <SectionHeader data={sectionHeader} className="center-content" id="AboutUs" />
          <div className={tilesClasses}>

            <div className="tiles-item reveal-from-bottom">
              <div className="tiles-item-inner">
                <div className="features-tiles-item-header">
                  
                </div>
                <div className="features-tiles-item-content">
                  <h4 className="mt-0 mb-8">
                    Civilian
                    </h4>
                  <p className="m-0 text-sm">
                                      Civilians can raise the online complaint and keep a track of the status of thier complaints. 
                    </p>
                </div>
              </div>
            </div>

            <div className="tiles-item reveal-from-bottom" data-reveal-delay="200">
              <div className="tiles-item-inner">
                <div className="features-tiles-item-header">
                
                </div>
                <div className="features-tiles-item-content">
                  <h4 className="mt-0 mb-8">
                    Police
                    </h4>
                  <p className="m-0 text-sm">
                                      Police who can go through all the complaints sequentially and take necessary actions while simultaneously updating the status of the complaints which can help civilians to understand the status of thier complaint.
                    </p>
                </div>
              </div>
            </div>

            <div className="tiles-item reveal-from-bottom" data-reveal-delay="400">
              <div className="tiles-item-inner">
                <div className="features-tiles-item-header">


                </div>
                <div className="features-tiles-item-content">
                  <h4 className="mt-0 mb-8">
                    Admin
                    </h4>
                  <p className="m-0 text-sm">
                                      Admin who can have to major control on the organization information related to latest regional office details and is responsible for keeping the system updated to latest information.
                    </p>
                </div>
              </div>
            </div>

            

            


          </div>
        </div>
      </div>
    </section>
  );
}

FeaturesTiles.propTypes = propTypes;
FeaturesTiles.defaultProps = defaultProps;

export default FeaturesTiles;