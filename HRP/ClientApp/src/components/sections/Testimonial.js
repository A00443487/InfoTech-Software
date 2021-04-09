import React from 'react';
import classNames from 'classnames';
import { SectionTilesProps } from '../../utils/SectionProps';
import SectionHeader from './partials/SectionHeader';

const propTypes = {
  ...SectionTilesProps.types
}

const defaultProps = {
  ...SectionTilesProps.defaults
}

const Testimonial = ({
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
    'testimonial section',
    topOuterDivider && 'has-top-divider',
    bottomOuterDivider && 'has-bottom-divider',
    hasBgColor && 'has-bg-color',
    invertColor && 'invert-color',
    className
  );

  const innerClasses = classNames(
    'testimonial-inner section-inner',
    topDivider && 'has-top-divider',
    bottomDivider && 'has-bottom-divider'
  );

  const tilesClasses = classNames(
    'tiles-wrap',
    pushLeft && 'push-left'
  );

  const sectionHeader = {
    title: 'Contact Us',
    //paragraph: 'Test'
  };

  return (
    <section
      {...props}
      className={outerClasses}
    >
      <div className="container">
        <div className={innerClasses}>
          <SectionHeader data={sectionHeader} className="center-content" id = "ContactUs" />
          <div className={tilesClasses}>



                      <div className="tiles-item reveal-from-left" data-reveal-delay="200">
                          <div className="tiles-item-inner">
                              <p className="text-sm mb-0">
                                  West Division (Mainland North & South, Bedford):
                                  15 Convoy Run, Bedford, Nova Scotia.
                                      <br></br>
                                      Contact number : 902.490.5200
                      </p>
                              <div className="testimonial-item-footer text-xs mt-32 mb-0 has-top-divider">
                                  <span className="testimonial-item-name text-color-high">Ben Stafford</span>
                                  <span className="text-color-low">  </span>
                                  <span className="testimonial-item-link">
                                      <a href="#0"></a>
                                  </span>
                              </div>
                          </div>
                      </div>





            <div className="tiles-item reveal-from-right" data-reveal-delay="200">
              <div className="tiles-item-inner">
                  <p className="text-sm mb-0">
                                      Central Division (Peninsular Halifax),
                                      1975 Gottingen Street, Halifax, Nova Scotia.
                                      <br></br>
                                      Contact Number : 902.490.5686
                      </p>
                <div className="testimonial-item-footer text-xs mt-32 mb-0 has-top-divider">
                  <span className="testimonial-item-name text-color-high">Roman Sigala</span>
                  <span className="text-color-low">  </span>
                  <span className="testimonial-item-link">
                    <a href="#0"></a>
                  </span>
                </div>
              </div>
            </div>

            <div className="tiles-item reveal-from-bottom">
              <div className="tiles-item-inner">
                  <p className="text-sm mb-0">
                                      East Division (Dartmouth): 
                                      7 Mellor Avenue, Dartmouth, Nova Scotia.
                                      <br></br>
                                      Contact Number : 902.490.5171
                      </p>
                <div className="testimonial-item-footer text-xs mt-32 mb-0 has-top-divider">
                  <span className="testimonial-item-name text-color-high">Diana Rynzhuk</span>
                  <span className="text-color-low">  </span>
                  <span className="testimonial-item-link">
                    <a href="#0"></a>
                  </span>
                </div>
              </div>
            </div>

            

          </div>
        </div>
      </div>
    </section>
  );
}

Testimonial.propTypes = propTypes;
Testimonial.defaultProps = defaultProps;

export default Testimonial;