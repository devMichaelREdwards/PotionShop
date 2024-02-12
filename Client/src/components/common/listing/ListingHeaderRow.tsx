import { nanoid } from 'nanoid';
import { List, FlexboxGrid } from 'rsuite';
import { IActionButton, IListingColumn } from '../../../types/IListing';
import EmptyColumns from './EmptyColumns';
import ActionButtonCollection from '../input/ActionButtonCollection';

interface IListingHeaderRowProps {
    columns: IListingColumn[];
    headerButtons?: IActionButton[];
    remove?: () => void;
}

const ListingHeaderRow = ({ columns, headerButtons, remove }: IListingHeaderRowProps) => {
    let colsLeft = 22; //24 - 2 for checkbox col
    return (
        <List.Item className='listing-header'>
            <FlexboxGrid>
                <EmptyColumns key={nanoid()} columns={2} />
                {columns.map((col) => {
                    colsLeft -= col.colspan;
                    return (
                        <FlexboxGrid.Item key={col.dataKey} colspan={col.colspan}>
                            {col.label}
                        </FlexboxGrid.Item>
                    );
                })}

                <ActionButtonCollection colspan={colsLeft} buttons={headerButtons} id={0} remove={remove} />
            </FlexboxGrid>
        </List.Item>
    );
};

export default ListingHeaderRow;
