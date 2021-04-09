import React from 'react';
import classNames from 'classnames';
import { Link } from 'react-router-dom';
import Image from '../../elements/Image';

const Logo = ({
  className,
  ...props
}) => {

  const classes = classNames(
    'brand',
    className
  );

  return (
    <div
      {...props}
      className={classes}
    >
      <h1 className="m-0">
              <Link to="/">
                  <Image
                      src={('https://upload.wikimedia.org/wikipedia/en/thumb/d/da/Halifax_Regional_Police.svg/1200px-Halifax_Regional_Police.svg.png')}
                      alt="Open"
                      width={80}
                      height={80} />
              </Link>
      </h1>
    </div>
  );
}

export default Logo;