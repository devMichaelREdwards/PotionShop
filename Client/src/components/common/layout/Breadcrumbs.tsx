import useBreadcrumbs from '../../../hooks/useBreadcrumbs';
import Crumb from './Crumb';

interface IProps {
    separator: string | JSX.Element;
}

const Breadcrumbs = ({ separator }: IProps) => {
    const breadcrumbs = useBreadcrumbs();

    return (
        <div className='breadcrumbs'>
            {breadcrumbs.map((crumb, i) => {
                const active = i == breadcrumbs.length - 1;
                return (
                    <>
                        <Crumb {...crumb} active={active} />
                        {!active && <span className='separator'>{separator}</span>}
                    </>
                );
            })}
        </div>
    );
};

export default Breadcrumbs;
